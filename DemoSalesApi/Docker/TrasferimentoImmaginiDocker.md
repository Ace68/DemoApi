# Sul PC Sorgente

## Per visulalizzare le immagini
docker images

## Esporta l'immagine
docker save -o brewup-sales.tar brewup-sales:latest

## Per ridurne la dimensione
gzip brewup-sales.tar

# Sul PC Destinazione

docker load -i brewup-sales.tar

## Se è compresso
gunzip -c brewup-sales.tar.gz | docker load

## Per verificare
docker images
