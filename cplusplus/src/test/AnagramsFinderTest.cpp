#include <gmock/gmock.h>

#include <kata/AnagramsFinder.h>

using kata::AnagramsFinder;

class AnagramsFinderTest: public testing::Test
{
public:
   class Thingie
   {
   public:
      virtual ~Thingie() = default;

      virtual void doStuff() = 0;
   };

   class MockedThing: public Thingie
   {
   public:
      MOCK_METHOD0(doStuff, void());
   };
};

TEST_F(AnagramsFinderTest, VerifyTestSystemWorks)
{
   bool value = true;

   EXPECT_EQ(true, value);
}

TEST_F(AnagramsFinderTest, VerifyMockingSystemWorks)
{
   MockedThing thing;

   EXPECT_CALL(thing, doStuff());

   thing.doStuff();
}
