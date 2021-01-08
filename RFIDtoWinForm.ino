/*
 * ----------------------------------------------------------------------------
 * This is a MFRC522 library example; see https://github.com/miguelbalboa/rfid
 * for further details and other examples.
 * 
 * NOTE: The library file MFRC522.h has a lot of useful info. Please read it.
 * 
 * Released into the public domain.
 * ----------------------------------------------------------------------------
 * Example sketch/program which will try the most used default keys listed in 
 * https://code.google.com/p/mfcuk/wiki/MifareClassicDefaultKeys to dump the
 * block 0 of a MIFARE RFID card using a RFID-RC522 reader.
 * 
 * Typical pin layout used:
 * -----------------------------------------------------------------------------------------
 *             MFRC522      Arduino       Arduino   Arduino    Arduino          Arduino
 *             Reader/PCD   Uno/101       Mega      Nano v3    Leonardo/Micro   Pro Micro
 * Signal      Pin          Pin           Pin       Pin        Pin              Pin
 * -----------------------------------------------------------------------------------------
 * RST/Reset   RST          9             5         D9         RESET/ICSP-5     RST
 * SPI SS      SDA(SS)      10            53        D10        10               10
 * SPI MOSI    MOSI         11 / ICSP-4   51        D11        ICSP-4           16
 * SPI MISO    MISO         12 / ICSP-1   50        D12        ICSP-1           14
 * SPI SCK     SCK          13 / ICSP-3   52        D13        ICSP-3           15
 *
 */

#include <SPI.h>
#include <MFRC522.h>

#define RST_PIN         5          
#define SS_PIN          53         

String tag1 = "e4 a5 90 2a";
String tag2 = "c3 56 a5 40"; 
String tag3 = "22 51 cf 34"; 
String tag4 = "e9 4a 81 9d"; 
String tag5 = "c0 03 3a 32";
String tag6 = "b0 94 a0 32";
String tag7 = "83 3d 47 02";
String tag8 = "e5 e1 5e 23";
String tag9 = "d5 99 55 23";
String tag10 = "f9 f2 b5 b2";
String tag11 = "f9 d8 0f c2";
String tag12 = "f9 2d e1 b0";
String tag13 = "d9 75 69 c2";
String tag14 = "29 ca f6 b8";
String tag15 = "39 a7 d9 a3";
String tag16 = "b9 ca 18 ba";
String tag17 = "69 7b 6d c2";
String tag18 = "09 83 f9 b8";
String tag19 = "2e 8e 61 19";
String tag20 = "49 08 29 c3";
String tag21 = "99 fc fc b9";
String tag22 = "89 5f f0 c2";
String tag23 = "e4 3d 50 2a";
String tag24 = "04 d7 cb 2b";
String tag25 = "13 e2 80 02";

MFRC522 mfrc522(SS_PIN, RST_PIN);   

#define NR_KNOWN_KEYS   8

byte knownKeys[NR_KNOWN_KEYS][MFRC522::MF_KEY_SIZE] =  {
    {0xff, 0xff, 0xff, 0xff, 0xff, 0xff}, // FF FF FF FF FF FF = factory default
    {0xa0, 0xa1, 0xa2, 0xa3, 0xa4, 0xa5}, // A0 A1 A2 A3 A4 A5
    {0xb0, 0xb1, 0xb2, 0xb3, 0xb4, 0xb5}, // B0 B1 B2 B3 B4 B5
    {0x4d, 0x3a, 0x99, 0xc3, 0x51, 0xdd}, // 4D 3A 99 C3 51 DD
    {0x1a, 0x98, 0x2c, 0x7e, 0x45, 0x9a}, // 1A 98 2C 7E 45 9A
    {0xd3, 0xf7, 0xd3, 0xf7, 0xd3, 0xf7}, // D3 F7 D3 F7 D3 F7
    {0xaa, 0xbb, 0xcc, 0xdd, 0xee, 0xff}, // AA BB CC DD EE FF
    {0x00, 0x00, 0x00, 0x00, 0x00, 0x00}  // 00 00 00 00 00 00
};

/*
 * Initialize.
 */
void setup() {
    Serial.begin(9600);         // Initialize serial communications with the PC
    while (!Serial);            // Do nothing if no serial port is opened (added for Arduinos based on ATMEGA32U4)
    SPI.begin(); 
    
    mfrc522.PCD_Init();         // Init MFRC522 card
}

/*
 * Helper routine to dump a byte array as hex values to Serial.
 */
String dump_byte_array(byte *buffer, byte bufferSize) {
  String output = "";
    for (byte i = 0; i < bufferSize; i++) {
        //Serial.print(buffer[i] < 0x10 ? " 0" : " ");
        //Serial.print(buffer[i], HEX);
        output += buffer[i] < 0x10 ? " 0" : " ";
        output += String(buffer[i], HEX);
    }
    return output;
}

/*
 * Try using the PICC (the tag/card) with the given key to access block 0.
 * On success, it will show the key details, and dump the block data on Serial.
 *
 * @return true when the given key worked, false otherwise.
 */
bool try_key(MFRC522::MIFARE_Key *key)
{
    bool result = false;
    byte buffer[18];
    byte block = 0;
    MFRC522::StatusCode status;
    
    status = mfrc522.PCD_Authenticate(MFRC522::PICC_CMD_MF_AUTH_KEY_A, block, key, &(mfrc522.uid));
    if (status != MFRC522::STATUS_OK) {
        return false;
    }

    byte byteCount = sizeof(buffer);
    status = mfrc522.MIFARE_Read(block, buffer, &byteCount);
    if (status != MFRC522::STATUS_OK) {
    }
    else {
        result = true;
    }

    mfrc522.PICC_HaltA();
    mfrc522.PCD_StopCrypto1();
    return result;
}

void loop() {
    
    if ( ! mfrc522.PICC_IsNewCardPresent())
        return;

    if ( ! mfrc522.PICC_ReadCardSerial())
        return;
        
    String uid = dump_byte_array(mfrc522.uid.uidByte, mfrc522.uid.size);

    Serial.println(uid); 
    MFRC522::PICC_Type piccType = mfrc522.PICC_GetType(mfrc522.uid.sak);
    MFRC522::MIFARE_Key key;
    for (byte k = 0; k < NR_KNOWN_KEYS; k++) {
        for (byte i = 0; i < MFRC522::MF_KEY_SIZE; i++) {
            key.keyByte[i] = knownKeys[k][i];
        }
        if (try_key(&key)) {
            break;
        }
    }
}
        
