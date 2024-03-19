using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSubdivideTetra
	/// </summary>
	/// <remarks>
	///    subdivide one tetrahedron into twelve for every tetra
	///
	/// This filter subdivides tetrahedra in an unstructured grid into twelve tetrahedra.
	/// </remarks>
	// Token: 0x02000572 RID: 1394
	public class vtkSubdivideTetra : vtkUnstructuredGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F738 RID: 63288 RVA: 0x00157A7C File Offset: 0x00155C7C
		static vtkSubdivideTetra()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSubdivideTetra.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSubdivideTetra"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F739 RID: 63289 RVA: 0x00157AA4 File Offset: 0x00155CA4
		public vtkSubdivideTetra(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F73A RID: 63290
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubdivideTetra_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F73B RID: 63291 RVA: 0x00157AB4 File Offset: 0x00155CB4
		public new static vtkSubdivideTetra New()
		{
			vtkSubdivideTetra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubdivideTetra.vtkSubdivideTetra_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubdivideTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F73C RID: 63292 RVA: 0x00157B08 File Offset: 0x00155D08
		public vtkSubdivideTetra() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSubdivideTetra.vtkSubdivideTetra_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F73D RID: 63293 RVA: 0x00157B4C File Offset: 0x00155D4C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F73E RID: 63294
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSubdivideTetra_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F73F RID: 63295 RVA: 0x00157B58 File Offset: 0x00155D58
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSubdivideTetra.vtkSubdivideTetra_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F740 RID: 63296
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSubdivideTetra_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F741 RID: 63297 RVA: 0x00157B78 File Offset: 0x00155D78
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSubdivideTetra.vtkSubdivideTetra_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F742 RID: 63298
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubdivideTetra_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F743 RID: 63299 RVA: 0x00157B94 File Offset: 0x00155D94
		public override int IsA(string type)
		{
			return vtkSubdivideTetra.vtkSubdivideTetra_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F744 RID: 63300
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSubdivideTetra_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F745 RID: 63301 RVA: 0x00157BB4 File Offset: 0x00155DB4
		public new static int IsTypeOf(string type)
		{
			return vtkSubdivideTetra.vtkSubdivideTetra_IsTypeOf_04(type);
		}

		// Token: 0x0600F746 RID: 63302
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubdivideTetra_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F747 RID: 63303 RVA: 0x00157BD0 File Offset: 0x00155DD0
		public new vtkSubdivideTetra NewInstance()
		{
			vtkSubdivideTetra result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubdivideTetra.vtkSubdivideTetra_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSubdivideTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F748 RID: 63304
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSubdivideTetra_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600F749 RID: 63305 RVA: 0x00157C2C File Offset: 0x00155E2C
		public new static vtkSubdivideTetra SafeDownCast(vtkObjectBase o)
		{
			vtkSubdivideTetra vtkSubdivideTetra = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSubdivideTetra.vtkSubdivideTetra_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSubdivideTetra = (vtkSubdivideTetra)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSubdivideTetra.Register(null);
				}
			}
			return vtkSubdivideTetra;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011F5 RID: 4597
		public new const string MRFullTypeName = "Kitware.VTK.vtkSubdivideTetra";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011F6 RID: 4598
		public new static readonly string MRClassNameKey = "class vtkSubdivideTetra";
	}
}
