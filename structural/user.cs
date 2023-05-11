// proxy pattern
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

class SocialMediaUserProxy implements SocialMediaAccount {
  private $socialMediaUser;

  public function getProfilePicture() {
    $this->initializeSocialMediaUser();
    return $this->socialMediaUser->getProfilePicture();
  }

  public function getFriends() {
    $this->initializeSocialMediaUser();
    return $this->socialMediaUser->getFriends();
  }

  private function initializeSocialMediaUser() {
    if (!$this->socialMediaUser) {
      $this->socialMediaUser = new SocialMediaUser();
    }
  }
}
}