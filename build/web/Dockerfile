### STAGE 1: Build ###
FROM node:12.7-alpine AS build
WORKDIR /usr/src/app
COPY ./src/web .
RUN npm install
RUN npm run build
### STAGE 2: Run ###
FROM nginx:1.17.1-alpine
COPY ./build/web/nginx.conf /etc/nginx/nginx.conf
COPY --from=build /usr/src/app/dist/operational-research-for-education /usr/share/nginx/html