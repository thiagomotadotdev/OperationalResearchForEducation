docker build \
    --no-cache \
    --file Dockerfile \
    --tag thiagomotadev/operational-research-for-education-api \
    ../../src/api

docker push \
    thiagomotadev/operational-research-for-education-api