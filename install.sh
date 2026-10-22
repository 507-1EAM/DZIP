#!/bin/bash

set -e

sudo curl -fsSL "https://raw.githubusercontent.com/507-1EAM/DZIP/master/bin/Debug/net8.0/DZIP" -o "DZIP"

sudo chmod +x DZIP
sudo mv DZIP /usr/bin/

echo ""
echo "Готово! DZIP успешно установлен."