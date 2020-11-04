# Frontend Example

#Start node

npm install

export BOOKSAPIURL=http://<HOST>:<PORT>
export BOOKSTOCKAPIURL=http://<HOST>:<PORT>

node app.js


# OCP setup
To test this sub project on ocp:



```
oc new-build --image-stream=openshift/nodejs:latest --name=bookstore-fe --binary=true
oc start-build bookstore-fe --from-dir=bookstore-node-fe 
oc new-app bookstore-fe -e PORT="8080" -e BOOKSAPIURL="booksurl" -e BOOKSTOCKAPIURL="stockurl" 
```

```
oc expose svc/bookstore-fe
```