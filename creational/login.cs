//singleton pattern
namespace DesignPatterns.singleton {

class Login {

  private static $instance;
  private $email;
  private $loggedIn = false;

  private function __construct() {}

  public static function getInstance() {
    if (!isset(self::$instance)) {
      self::$instance = new Login();
    }
    return self::$instance;
  }

  public function attemptLogin($email, $password) {
    // Your login logic here
    if (!empty($email)) {
      $this->email = $email;
      $this->loggedIn = true;
      return true;
    } else {
      return false;
    }
  }

  public function isLoggedIn() {
    return $this->loggedIn;
  }

  public function getEmail() {
    return $this->email;
  }

  private function __clone() {}
}
}