// singleton pattern
namespace DesignPatterns.singleton{
    class Signup {

  private static $instance;
  private $user_name;

  private function __construct() {}

  public static function getInstance() {
    if (!isset(self::$instance)) {
      self::$instance = new Signup();
    }
    return self::$instance;
  }

  public function attemptSignup($user_name, $email, $password) {
    // Your sign-up logic here
    if ( isset($user_name)== $user_name && isset($email)== $email){
      /* Check whether the username and email are available, and whether the password meets the requirements */ 
      $this->user_name = $user_name;
      return true;
    } else {
      return false;
    }
  }

  public function getUsername() {
    return $this->user_name;
  }

  private function __clone() {}
}
}