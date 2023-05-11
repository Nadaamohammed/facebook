// singleton pattern
namespace DesignPatterns.singleton
{
    class Profile {
  private $user_name;
  private $profilePicture;

  private static $instance;

  private function __construct() {
    // Load username and profile picture from the database or API
    $this->username = 'JohnDoe';
    $this->profilePicture = 'assets/images/users/user1.jpg';
  }

  public static function getInstance() {
    if (!isset(self::$instance)) {
      self::$instance = new Profile();
    }
    return self::$instance;
  }

  public function getUsername() {
    return $this->user_name;
  }

  public function getProfilePicture() {
    return $this->profilePicture;
  }
}
}