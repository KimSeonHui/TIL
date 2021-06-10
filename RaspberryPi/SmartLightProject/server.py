import socket
import time
import bh1750Thread
import led

host = '172.20.10.4'
port = 8080

server_sock = socket.socket(socket.AF_INET)
server_sock.bind((host, port))
server_sock.listen(1)

print('wating')

while True :
    client_sock, addr = server_sock.accept()
    
    if client_sock :
    print('Connected by', addr)
    in_data = client_sock.recv(1024)
    print('rev :', in_data.decode('utf-8'), len(in_data))
    i = 0
    
    while i < 5 :
        out_data = bh1750Thread.readIlluminance()
        client_sock.send(out_data.to_bytes(4, byteorder='little'))
        print('send : ', out_data)
        data = client_sock.recv(1024)
        state = data.decode('utf-8')
        print(data)
        led.turnLed(data)
        print('rev :', data.decode('utf-8'))
        
        i = i+1
        time.sleep(5)

client_sock.close()
server_sock.close()