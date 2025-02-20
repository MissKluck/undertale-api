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
  document.querySelector('.card-stage').textContent = data.Stage;
  document.querySelector('.card-hp').textContent = 'HP: ' + data.HP;
  document.querySelector('.card-at').textContent = 'AT: ' + data.AT;
  document.querySelector('.card-df').textContent = 'DF: ' + data.DF;
  document.querySelector('.card-type').textContent = 'Type: ' + data.Type;
  document.querySelector('.card-extra').textContent = data.ExtraInfo;
  document.querySelector('.card-info').textContent = data.Info;

  let abilitiesList = document.querySelector('.card-abilities');
  abilitiesList.textContent = 'Abilities: ' + data.Abilities.join(', ');

  let affinitiesList = document.querySelector('.card-affinities');
  affinitiesList.textContent = 'Affinities: ' + data.Affinities.join(', ');

  document.querySelector('.card-image img').src = data.ImageUrl;

  // Apply special effects for Sans
  let cardElement = document.querySelector('.card');
  if (data.Name.toLowerCase() === 'sans') {
    cardElement.classList.add('sans-glitch');
  } else {
    cardElement.classList.remove('sans-glitch');
  }
}
