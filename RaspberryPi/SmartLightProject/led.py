import RPi.GPIO as GPIO
import time

GPIO.setmode(GPIO.BCM)
GPIO.setup(17, GPIO.OUT)
GPIO.output(17, False)

def turnLed(state) :
    if state == b'\x00\x03OFF' :
        GPIO.output(17,False)
    if state == b'\x00\x02ON' : 
        GPIO.output(17, True)

