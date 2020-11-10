# Tekton Demo

An demo for tekton on OCP 4.x.

# Setup

## Helm

Test the chart:

```helm install --dry-run bookstore-chart/```

Installa the chart:
```helm install --generate-name bookstore-chart/```

To check:
```helm list```

To upgrade the chart:
```helm upgrade bookstore-chart-<NUMBER>  bookstore-chart/```

Uninstall the chart
```helm uninstall bookstore-chart-<NUMBER>```

# The pipeline