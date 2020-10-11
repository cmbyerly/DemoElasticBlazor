# DemoElasticBlazor
This is for the YouTube series I am putting together for using Elasticsearch with C#

# Commands from the First Video

- `docker run --restart=always -d --name elastic -p 9200:9200 -p 9300:9300 -e "discovery.type=single-node" docker.elastic.co/elasticsearch/elasticsearch:7.9.1`
- `docker run --restart=always -d --name kibana --link elastic:elasticsearch -p 5601:5601 docker.elastic.co/kibana/kibana:7.9.1`
- `docker run --restart=always -d --name logstash --link elastic:elasticsearch docker.elastic.co/logstash/logstash:7.9.1`
- `docker run --restart=always -d --name apm --link elastic:elasticsearch -p 8200:8200 docker.elastic.co/apm/apm-server:7.9.1`

# Second Video - Enabling with Serilog on Server

You will need to install the following Nuget Libraries to DemoElasticBlazor.Server.csproj.  The initial project will be in the "Initial" directory.  The my fully configured one will be in the "Logging" Directory for your reference.

- Elasticsearch.Net
- NEST
- Newtonsoft.Json
- Serilog
- Serilog.AspNetCore
- Serilog.Extensions.Logging
- Serilog.Sinks.Elasticsearch

# Third Video - Writing to An Index Directly

In this video we discussed writing directly to an index.  The project for it is WriteToIndex folder.