# Tekton Demo

An demo for tekton on OCP 4.x.

# Setup

The demo is installed with [Helm](https://heml.io/).

The chart is located in the ```bookstore-chart``` folder.

1. Create a new OpenShift project:

```oc new-project bookstore-pipeline-demo```

2. Install Tekton Operator (Optional if not installed)

```oc apply -f pipelines-operator.yaml```

3. Customize the chart values before running.
   Update the `ocpHostDomain` with your current OCP domain URL before running the chart:

   ```
   sed -i 's/^ocpHostDomain: "<CHANGE_TO_YOUR_HOST>"/ocpHostDomain: ocp4.demo.example.com/g' bookstore-chart/values.yaml
   ```

   Alternatively, it is possible to dinamically override a value from command line
   with the `--set key=value` option without touching the `bookstore-chart/values.yaml` file.

4. Test the chart with a dry run (just to be sure that everyrhing is formally fine):

```helm install --generate-name --dry-run bookstore-chart```

5. Go to the project source root and install the chart: 

```helm install --generate-name bookstore-chart```

6. Start the Tekton pipelines

   ```oc apply -f pipelineruns/```


Alternatively Login into web console and run the three pipelines:

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

