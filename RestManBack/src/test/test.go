package main

import (
	"bytes"
	"encoding/json"
	"fmt"
	"io/ioutil"
	"net/http"
)

func main() {
	jsonData := map[string]string{"url": "http://localhost:8000/categories",  "method": "GET"}
	jsonValue, _ := json.Marshal(jsonData)
	request, _ := http.NewRequest("POST", "http://localhost:8001/Data", bytes.NewBuffer(jsonValue))
	//request, _ := http.NewRequest("DELETE", "http://localhost:8000/categorie/4", bytes.NewBuffer(jsonValue))
	request.Header.Set("Content-Type", "application/json")
	client := &http.Client{}
	response, err := client.Do(request)
	if err != nil {
		fmt.Printf("The HTTP request failed with error %s\n", err)
	} else {
		data, _ := ioutil.ReadAll(response.Body)
		fmt.Println(string(data))
	}
}