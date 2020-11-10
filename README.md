# Tekton Demo

An example on how to use tekton on OCP 4.x.

# Setup

## Heml

Test the chart:

```helm install --dry-run bookstore-chart/```

Installa the chart:

```helm install --generate-name bookstore-chart/```

To check:
``helm list```

To upgrade the chart:

```helm upgrade bookstore-chart-<NUMBER>  bookstore-chart/```

```helm uninstall bookstore-chart-<NUMBER>```

# The pipeline