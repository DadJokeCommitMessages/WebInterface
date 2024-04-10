window.copyClipboard = (dadJoke) => {
    var copyText = 'git commit -m "' + dadJoke + '"';
    navigator.clipboard.writeText(copyText)
    alert("Copied the text: " + copyText);
}