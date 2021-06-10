import smbus
import threading
import time

I2C_CH = 1
BH1750_DEV_ADDR = 0x23

CONT_H_RES_MODE = 0x10
CONT_H_RES_MODE2 = 0x11
CONT_L_RES_MODE = 0x13
ONETIME_H_RES_MODE = 0x20
ONETIME_H_RES_MODE2 = 0x21
ONETIME_L_RES_MODE = 0x23

def readIlluminace() :
    i2c = smbus.SMBus(I2C_CH)
    luxBytes = i2c.read_i2c_block_data(BH1750_DEV_ADDR, CONT_H_RES_MODE, 2)
    lux = int.from_bytes(luxBytes, byteorder='big')
    i2c.close()
    return lux   

def readIlluminaceThread() :
    while True :
        print('{0} lux'.format(readIlluminace()))
        time.sleep

print('starting BH1750')
print('Press Enter key to exit')
thd = threading.Thread(target=readIlluminaceThread)
thd.daemon = True
thd.start()
