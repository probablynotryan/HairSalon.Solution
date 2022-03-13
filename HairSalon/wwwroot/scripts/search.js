const search = () => {
  let input = document.getElementById('search-clients');
  let filter = input.value.toLowerCase();
  const ul = document.getElementById('client-box');
  const li = ul.getElementsByTagName('li');

  for (i = 0; i < li.length; i++) {
    let txtValue = li[i].textContent || li[i].innerText;
    if (txtValue.toLowerCase().indexOf(filter) > -1) {
      li[i].style.display = "";
    } else {
      li[i].style.display = "none";
    }
  }
}

