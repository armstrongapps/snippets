// Fetch JSON
async function FetchJSON() {
    fetch("https://example.com/movies.json")
    .then((response) => response.json())
    .then((data) => console.log(data));
}

// Fetch HTML and display it the DOM's body elemeent
async function FetchHTML() {
    fetch("./file.html")
    .then((response) => {
        return response.text();
    })
    .then((html) => {
        document.body.innerHTML = html;
    });
}