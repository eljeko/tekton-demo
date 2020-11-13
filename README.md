# Tekton Demo

An demo for tekton on OCP 4.x.

# Setup

The demo is installed with [Helm](https://heml.io/).

The chart is located in the ```bookstore-chart``` folder.

1. Create a new OpenShift project:

```oc create new-project bookstore-pipeline-demo```

2. Test the chart (just to be sure that everyrhing is formally fine):

```helm install --generate-name --dry-run bookstore-chart```

3. Go to the project source root and install the chart: 

```helm install --generate-name bookstore-chart```

4. At the end of installation in  the *"Post install Front End setup for demo"* the chart will **output a command** to update the frontend deployment environment variables with urls of the two ReST services: **copy the command and run it** (you need to be logged in your openshift). The command is something like:

```
oc patch  deployment/bookstore-chart-1605264575-fe -p "{\"spec\":{\"template\":{\"spec\":{\"containers\":[{\"env\":[{\"name\":\"BOOKSAPIURL\",\"value\":\"http://$(oc get route bookstore-books-api -o jsonpath='{.status.ingress[0].host}' --namespace bookstore-demo)\"},{\"name\":\"BOOKSTOCKAPIURL\",\"value\":\"http://$(oc get route bookstore-stock-api  -o jsonpath='{.status.ingress[0].host}' --namespace bookstore-demo)\"}],\"name\":\"bookstore-chart-fe\"}]}}}}" --namespace bookstore-demo
```

5. Login into web console and run the three pipeline:
    
    * ```front-end-pipeline``` (run the pipeline with the pvc ```fe-pipeline-pvc```)
    * ```books-api-pipeline``` (run the pipeline with the pvc ```books-api-pipeline-pvc```)    
    * ```stock-api-pipeline``` (run the pipeline with the pvc ```stock-api-pipeline-pvc```)

At the end you will have the three applications running.

## Front-end app

This is a nodejs front end app that uses the ReST services to compose the page.

## Books API

This is a java spring-boot ReST service. Is the list of books available.

To test it from browser you can point to 

## Stock API

This is a dotnet ReST service. Is the number of books available for online store.

