using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkRemoveIsolatedVertices
	/// </summary>
	/// <remarks>
	///    remove vertices of a vtkGraph with
	///    degree zero.
	///
	///
	/// </remarks>
	// Token: 0x0200068F RID: 1679
	public class vtkRemoveIsolatedVertices : vtkGraphAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601202B RID: 73771 RVA: 0x0019369B File Offset: 0x0019189B
		static vtkRemoveIsolatedVertices()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkRemoveIsolatedVertices.MRClassNameKey, Type.GetType("Kitware.VTK.vtkRemoveIsolatedVertices"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601202C RID: 73772 RVA: 0x001936C3 File Offset: 0x001918C3
		public vtkRemoveIsolatedVertices(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601202D RID: 73773
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveIsolatedVertices_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601202E RID: 73774 RVA: 0x001936D4 File Offset: 0x001918D4
		public new static vtkRemoveIsolatedVertices New()
		{
			vtkRemoveIsolatedVertices result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveIsolatedVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601202F RID: 73775 RVA: 0x00193728 File Offset: 0x00191928
		public vtkRemoveIsolatedVertices() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012030 RID: 73776 RVA: 0x0019376C File Offset: 0x0019196C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012031 RID: 73777
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemoveIsolatedVertices_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012032 RID: 73778 RVA: 0x00193778 File Offset: 0x00191978
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06012033 RID: 73779
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkRemoveIsolatedVertices_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012034 RID: 73780 RVA: 0x00193798 File Offset: 0x00191998
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06012035 RID: 73781
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemoveIsolatedVertices_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012036 RID: 73782 RVA: 0x001937B4 File Offset: 0x001919B4
		public override int IsA(string type)
		{
			return vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012037 RID: 73783
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkRemoveIsolatedVertices_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012038 RID: 73784 RVA: 0x001937D4 File Offset: 0x001919D4
		public new static int IsTypeOf(string type)
		{
			return vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_IsTypeOf_04(type);
		}

		// Token: 0x06012039 RID: 73785
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveIsolatedVertices_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601203A RID: 73786 RVA: 0x001937F0 File Offset: 0x001919F0
		public new vtkRemoveIsolatedVertices NewInstance()
		{
			vtkRemoveIsolatedVertices result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkRemoveIsolatedVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601203B RID: 73787
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkRemoveIsolatedVertices_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601203C RID: 73788 RVA: 0x0019384C File Offset: 0x00191A4C
		public new static vtkRemoveIsolatedVertices SafeDownCast(vtkObjectBase o)
		{
			vtkRemoveIsolatedVertices vtkRemoveIsolatedVertices = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkRemoveIsolatedVertices.vtkRemoveIsolatedVertices_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkRemoveIsolatedVertices = (vtkRemoveIsolatedVertices)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkRemoveIsolatedVertices.Register(null);
				}
			}
			return vtkRemoveIsolatedVertices;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014C9 RID: 5321
		public new const string MRFullTypeName = "Kitware.VTK.vtkRemoveIsolatedVertices";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040014CA RID: 5322
		public new static readonly string MRClassNameKey = "class vtkRemoveIsolatedVertices";
	}
}
