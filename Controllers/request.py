import requests

response = requests.get('http://localhost:4200', body={"lastName": "Trurans"})

response.text
