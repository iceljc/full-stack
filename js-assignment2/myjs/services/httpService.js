class HttpService {

    get(url) {
        return fetch(url).then(response => {
            if (!response.ok) {
                throw new Error("Something went wrong!");
            }
            return response.json();
        });
    }

}

export default HttpService;