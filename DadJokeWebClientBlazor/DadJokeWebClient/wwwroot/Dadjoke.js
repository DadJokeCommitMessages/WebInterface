window.copyClipboard = (dadJoke) => {
    var copyText = 'git commit -m "' + dadJoke + '"';
    Navigator.clipboard.writeText(copyText)
    alert("Copied the text: " + copyText);
}