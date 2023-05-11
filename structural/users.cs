// delegation pattern
namespace DesignPatterns.StructuralPatterns{
    interface SocialMediaAccount {
  public function getProfilePicture();
  public function getFriends();
}

class SocialMediaUser implements SocialMediaAccount {
  private $profilePicture;
  private $friends;

  public function __construct() {
    // Load profile picture and friends list from the database or API
    $this->profilePicture = 'assets/images/users/user1.jpg';
    $this->friends = ['Alice', 'Bob', 'Charlie'];
  }

  public function getProfilePicture() {
    return $this->profilePicture;
  }

  public function getFriends() {
    return $this->friends;
  }
}

class User implements SocialMediaAccount {
  private $socialMediaAccount;

  public function __construct() {
    $this->socialMediaAccount = new SocialMediaUser();
  }

  public function getProfilePicture() {
    return $this->socialMediaAccount->getProfilePicture();
  }

  public function getFriends() {
    return $this->socialMediaAccount->getFriends();
  }
}
}