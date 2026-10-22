#!/bin/bash

set -e

sudo curl -fsSL "https://github.com/507-1EAM/DZIP/raw/refs/heads/master/bin/Release/net8.0/linux-x64/publish/DZIP" -o "DZIP"

sudo chmod +x DZIP
sudo mv DZIP /usr/bin/

echo ""
echo "Готово! DZIP успешно установлен."