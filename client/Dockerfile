# Client
FROM node:16-alpine as angular-built
WORKDIR /client
RUN npm i -g @angular/cli@13.2.5
COPY package.json package.json
COPY package-lock.json package-lock.json
RUN npm install --silent
COPY . .
RUN ng build --configuration production --aot --build-optimizer

FROM nginx:alpine
COPY /nginx.conf /etc/nginx/nginx.conf
COPY --from=angular-built /client/dist/LoL.Stats /usr/share/nginx/html
EXPOSE 80
EXPOSE 443
CMD [ "nginx", "-g", "daemon off;" ]