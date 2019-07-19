using GraphQL.Types;
using OrchardCore.ContentManagement;
using OrchardCore.Forms.Models;

namespace OrchardCore.Forms.GraphQL
{
    public class LabelPartQueryObjectType : ObjectGraphType<LabelPart>
    {
        public LabelPartQueryObjectType()
        {
            Name = "LabelPart";

            Field(x => x.For, nullable: true);
            Field<StringGraphType>("value", resolve: context =>
            {
                return context.Source.ContentItem.DisplayText;
            });
        }
    }
}