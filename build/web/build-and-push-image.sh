docker build \
    --no-cache \
    --file Dockerfile \
    --tag thiagomotadev/operational-research-for-education-web \
    ../../

docker push \
    thiagomotadev/operational-research-for-education-web