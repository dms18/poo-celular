﻿using DesafioPOO.Models;

Iphone iphone = new Iphone("123456789", "iPhone 12", "123456789012345", 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
iphone.ReceberLigacao();

Nokia nokia = new Nokia("987654321", "Nokia 3310", "987654321098765", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Snake");
nokia.ReceberLigacao();