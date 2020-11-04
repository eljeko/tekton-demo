# Manual deploy


## build the app locally

```
cd spring-boot-rest-service
```

```
mvn clean package spring-boot:repackage
```

## Create the binary builder

We can create the builder for our application:

```
oc new-app redhat-openjdk18-openshift:1.8 --binary --name=bookstore-books-api
```

```
oc start-build bookstore-books-api --from-file target/bookstore-books-rest-api-1.0.jar
```

## Expose the service as route.

```
oc expose svc bookstore-books-api
```