using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStringToken
	/// </summary>
	/// <remarks>
	///    Represent a string by its integer hash.
	///
	/// This class does not inherit vtkObject; it is a lightweight
	/// object for representing a string as a 32-bit integer token.
	/// Tokens can be constructed at compile-time (via the ""_token
	/// string-literal operator below) or run-time (via the constructor).
	///
	/// Equality comparisons are simple integer tests, while
	/// inequality operators attempt to locate the original source
	/// strings and compare them alphanumerically to preserve
	/// lexicographic ordering.
	///
	/// This class can be used inside ordered and unordered
	/// STL containers.
	/// </remarks>
	// Token: 0x02000B80 RID: 2944
	public class vtkStringToken : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EB99 RID: 125849 RVA: 0x002B934B File Offset: 0x002B754B
		static vtkStringToken()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStringToken.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringToken"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EB9A RID: 125850 RVA: 0x002B9373 File Offset: 0x002B7573
		public vtkStringToken(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EB9B RID: 125851 RVA: 0x002B9381 File Offset: 0x002B7581
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EB9C RID: 125852
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToken_AddChild_01(HandleRef pThis, vtkStringToken member);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB9D RID: 125853 RVA: 0x002B938C File Offset: 0x002B758C
		public bool AddChild(vtkStringToken member)
		{
			return vtkStringToken.vtkStringToken_AddChild_01(base.GetCppThis(), member) != 0;
		}

		// Token: 0x0601EB9E RID: 125854
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkStringToken_Data_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EB9F RID: 125855 RVA: 0x002B93B4 File Offset: 0x002B75B4
		public string Data()
		{
			return vtkStringToken.vtkStringToken_Data_02(base.GetCppThis());
		}

		// Token: 0x0601EBA0 RID: 125856
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkStringToken_GetHash_03(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBA1 RID: 125857 RVA: 0x002B93D4 File Offset: 0x002B75D4
		public uint GetHash()
		{
			return vtkStringToken.vtkStringToken_GetHash_03(base.GetCppThis());
		}

		// Token: 0x0601EBA2 RID: 125858
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkStringToken_GetId_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBA3 RID: 125859 RVA: 0x002B93F4 File Offset: 0x002B75F4
		public uint GetId()
		{
			return vtkStringToken.vtkStringToken_GetId_04(base.GetCppThis());
		}

		// Token: 0x0601EBA4 RID: 125860
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToken_HasData_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBA5 RID: 125861 RVA: 0x002B9414 File Offset: 0x002B7614
		public bool HasData()
		{
			return vtkStringToken.vtkStringToken_HasData_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EBA6 RID: 125862
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkStringToken_InvalidHash_06();

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBA7 RID: 125863 RVA: 0x002B943C File Offset: 0x002B763C
		public static uint InvalidHash()
		{
			return vtkStringToken.vtkStringToken_InvalidHash_06();
		}

		// Token: 0x0601EBA8 RID: 125864
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToken_IsValid_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBA9 RID: 125865 RVA: 0x002B9458 File Offset: 0x002B7658
		public bool IsValid()
		{
			return vtkStringToken.vtkStringToken_IsValid_07(base.GetCppThis()) != 0;
		}

		// Token: 0x0601EBAA RID: 125866
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStringToken_RemoveChild_08(HandleRef pThis, vtkStringToken member);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBAB RID: 125867 RVA: 0x002B9480 File Offset: 0x002B7680
		public bool RemoveChild(vtkStringToken member)
		{
			return vtkStringToken.vtkStringToken_RemoveChild_08(base.GetCppThis(), member) != 0;
		}

		// Token: 0x0601EBAC RID: 125868
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkStringToken_StringHash_09([MarshalAs(UnmanagedType.LPUTF8Str)] string data, ulong size);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EBAD RID: 125869 RVA: 0x002B94A8 File Offset: 0x002B76A8
		public static uint StringHash(string data, ulong size)
		{
			return vtkStringToken.vtkStringToken_StringHash_09(data, size);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020E7 RID: 8423
		public new const string MRFullTypeName = "Kitware.VTK.vtkStringToken";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020E8 RID: 8424
		public new static readonly string MRClassNameKey = "class vtkStringToken";
	}
}
