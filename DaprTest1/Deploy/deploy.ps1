kubectl apply `
    -f namespace.yaml `
    -f zipkin.yaml `
    -f dapr-config.yaml `
    -f components/redis.yaml `
    -f components/statestore.yaml `
    -f components/pubsub.yaml `
    -f components/sendemail.yaml `
    -f blazorweb.yaml `
    -f serviceapi1.yaml
