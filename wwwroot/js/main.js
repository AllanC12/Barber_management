const fetchData = async (url, method, dataRequest) => {
    let data;
    switch (method) {
        case "GET": const response = await fetch(url)
            data = await response.json()
            break;

        case "POST": const responsePost = await fetch(url, {
            method: "POST",
            headers: {
                "Content-Type": "application/json"
            },
            body: JSON.stringify({
                SearchTerm: dataRequest
            })
        })
            data = await responsePost.json()
            break;

        default: throw new Error("Ocorreu algum erro!")
           
    }
    return data;
}