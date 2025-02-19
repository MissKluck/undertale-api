document.addEventListener('DOMContentLoaded', () => {
  fetchCard('sans');
});

function fetchCard(name) {
  fetch(`https://localhost:5095/api/cards/${sans}`)
    .then((response) => response.json())
    .then((data) => generateCard(data))
    .catch((error) => console.error('Error fetching card:', error));
}

function generateCard(data) {
  document.querySelector('.card-name').textContent = data.Name;
  document.querySelector('.card-hp').textContent = data.hp + ' HP';
}
