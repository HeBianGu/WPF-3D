using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGroupLeafVertices
	/// </summary>
	/// <remarks>
	///    Filter that expands a tree, categorizing leaf vertices
	///
	///
	/// Use SetInputArrayToProcess(0, ...) to set the array to group on.
	/// Currently this array must be a vtkStringArray.
	/// </remarks>
	// Token: 0x02000681 RID: 1665
	public class vtkGroupLeafVertices : vtkTreeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011E5D RID: 73309 RVA: 0x00190C2F File Offset: 0x0018EE2F
		static vtkGroupLeafVertices()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGroupLeafVertices.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGroupLeafVertices"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011E5E RID: 73310 RVA: 0x00190C57 File Offset: 0x0018EE57
		public vtkGroupLeafVertices(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011E5F RID: 73311
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGroupLeafVertices_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E60 RID: 73312 RVA: 0x00190C68 File Offset: 0x0018EE68
		public new static vtkGroupLeafVertices New()
		{
			vtkGroupLeafVertices result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGroupLeafVertices.vtkGroupLeafVertices_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGroupLeafVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E61 RID: 73313 RVA: 0x00190CBC File Offset: 0x0018EEBC
		public vtkGroupLeafVertices() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGroupLeafVertices.vtkGroupLeafVertices_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011E62 RID: 73314 RVA: 0x00190D00 File Offset: 0x0018EF00
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011E63 RID: 73315
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGroupLeafVertices_GetGroupDomain_01(HandleRef pThis);

		/// <summary>
		/// The name of the domain that non-leaf vertices will be assigned to.
		/// If the input graph already contains vertices in this domain:
		/// - If the ids for this domain are numeric, starts assignment with max id
		/// - If the ids for this domain are strings, starts assignment with "group X"
		/// where "X" is the max id.
		/// Default is "group_vertex".
		/// </summary>
		// Token: 0x06011E64 RID: 73316 RVA: 0x00190D0C File Offset: 0x0018EF0C
		public virtual string GetGroupDomain()
		{
			string s = Marshal.PtrToStringAnsi(vtkGroupLeafVertices.vtkGroupLeafVertices_GetGroupDomain_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06011E65 RID: 73317
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGroupLeafVertices_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E66 RID: 73318 RVA: 0x00190D48 File Offset: 0x0018EF48
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGroupLeafVertices.vtkGroupLeafVertices_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06011E67 RID: 73319
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGroupLeafVertices_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E68 RID: 73320 RVA: 0x00190D68 File Offset: 0x0018EF68
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGroupLeafVertices.vtkGroupLeafVertices_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06011E69 RID: 73321
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGroupLeafVertices_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E6A RID: 73322 RVA: 0x00190D84 File Offset: 0x0018EF84
		public override int IsA(string type)
		{
			return vtkGroupLeafVertices.vtkGroupLeafVertices_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06011E6B RID: 73323
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGroupLeafVertices_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E6C RID: 73324 RVA: 0x00190DA4 File Offset: 0x0018EFA4
		public new static int IsTypeOf(string type)
		{
			return vtkGroupLeafVertices.vtkGroupLeafVertices_IsTypeOf_05(type);
		}

		// Token: 0x06011E6D RID: 73325
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGroupLeafVertices_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E6E RID: 73326 RVA: 0x00190DC0 File Offset: 0x0018EFC0
		public new vtkGroupLeafVertices NewInstance()
		{
			vtkGroupLeafVertices result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGroupLeafVertices.vtkGroupLeafVertices_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGroupLeafVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011E6F RID: 73327
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGroupLeafVertices_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011E70 RID: 73328 RVA: 0x00190E1C File Offset: 0x0018F01C
		public new static vtkGroupLeafVertices SafeDownCast(vtkObjectBase o)
		{
			vtkGroupLeafVertices vtkGroupLeafVertices = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGroupLeafVertices.vtkGroupLeafVertices_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGroupLeafVertices = (vtkGroupLeafVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGroupLeafVertices.Register(null);
				}
			}
			return vtkGroupLeafVertices;
		}

		// Token: 0x06011E71 RID: 73329
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkGroupLeafVertices_SetGroupDomain_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// The name of the domain that non-leaf vertices will be assigned to.
		/// If the input graph already contains vertices in this domain:
		/// - If the ids for this domain are numeric, starts assignment with max id
		/// - If the ids for this domain are strings, starts assignment with "group X"
		/// where "X" is the max id.
		/// Default is "group_vertex".
		/// </summary>
		// Token: 0x06011E72 RID: 73330 RVA: 0x00190E9B File Offset: 0x0018F09B
		public virtual void SetGroupDomain(string _arg)
		{
			vtkGroupLeafVertices.vtkGroupLeafVertices_SetGroupDomain_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014AB RID: 5291
		public new const string MRFullTypeName = "Kitware.VTK.vtkGroupLeafVertices";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014AC RID: 5292
		public new static readonly string MRClassNameKey = "class vtkGroupLeafVertices";
	}
}
