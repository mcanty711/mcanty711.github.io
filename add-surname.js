/* Prompts user to add last name */
function tipUsername() {                          // Declare function
  //elMsg.className = 'tip';                        // Change class for message
  elMsg.innerHTML = 'Please remember to include your last name'; // Add message
}

var el = document.getElementById('names');     // Username input
var elMsg = document.getElementById('feedback');  // Element to hold message

// When the username input gains / loses focus call functions above:
el.addEventListener('focus', tipUsername, false); // focus call tipUsername()
