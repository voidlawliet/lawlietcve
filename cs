-zip2john file.zip
-zip2john file.zip> rame.hash

no wordlist
john rame.hash

wordlist
zip2john file.zip>rame.hash
john rame.hash - -wordlist=wordlistfile

wordlist -
tail -n 50000 wordlistfile > new.txt

head -n 50000 wordlistfile > ne w.txt
john rame.hash - - wordlist=new.txt
crunch
crunch 46'123456789' > new.txt
John rame.hash - - wordlist=new.txt

sudo unshadow /etc/passwd /etc/shadow > nebismieri

John nebismieri
John - -format=crypt - -user=patricia - -incremental=digits nebismieri