# Frontend Example

To test this sub project on ocp:

```
oc new-build --image-stream=openshift/httpd:latest --name=bookstore-fe --binary=true
oc start-build bookstore-fe --from-dir=www
oc new-app bookstore-fe
```

```
oc expose svc/bookstore-fe
```