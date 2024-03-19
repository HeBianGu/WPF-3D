using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGenericOutlineFilter
	/// </summary>
	/// <remarks>
	///    create wireframe outline for arbitrary
	/// generic data set
	///
	///
	/// vtkGenericOutlineFilter is a filter that generates a wireframe outline of
	/// any generic data set. The outline consists of the twelve edges of the
	/// generic dataset bounding box.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkGenericDataSet
	/// </seealso>
	// Token: 0x0200049E RID: 1182
	public class vtkGenericOutlineFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DA26 RID: 55846 RVA: 0x0012EC09 File Offset: 0x0012CE09
		static vtkGenericOutlineFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGenericOutlineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGenericOutlineFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DA27 RID: 55847 RVA: 0x0012EC31 File Offset: 0x0012CE31
		public vtkGenericOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DA28 RID: 55848
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA29 RID: 55849 RVA: 0x0012EC40 File Offset: 0x0012CE40
		public new static vtkGenericOutlineFilter New()
		{
			vtkGenericOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericOutlineFilter.vtkGenericOutlineFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA2A RID: 55850 RVA: 0x0012EC94 File Offset: 0x0012CE94
		public vtkGenericOutlineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkGenericOutlineFilter.vtkGenericOutlineFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DA2B RID: 55851 RVA: 0x0012ECD8 File Offset: 0x0012CED8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DA2C RID: 55852
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericOutlineFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA2D RID: 55853 RVA: 0x0012ECE4 File Offset: 0x0012CEE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGenericOutlineFilter.vtkGenericOutlineFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600DA2E RID: 55854
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGenericOutlineFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA2F RID: 55855 RVA: 0x0012ED04 File Offset: 0x0012CF04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGenericOutlineFilter.vtkGenericOutlineFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600DA30 RID: 55856
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericOutlineFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA31 RID: 55857 RVA: 0x0012ED20 File Offset: 0x0012CF20
		public override int IsA(string type)
		{
			return vtkGenericOutlineFilter.vtkGenericOutlineFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600DA32 RID: 55858
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGenericOutlineFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA33 RID: 55859 RVA: 0x0012ED40 File Offset: 0x0012CF40
		public new static int IsTypeOf(string type)
		{
			return vtkGenericOutlineFilter.vtkGenericOutlineFilter_IsTypeOf_04(type);
		}

		// Token: 0x0600DA34 RID: 55860
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOutlineFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA35 RID: 55861 RVA: 0x0012ED5C File Offset: 0x0012CF5C
		public new vtkGenericOutlineFilter NewInstance()
		{
			vtkGenericOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericOutlineFilter.vtkGenericOutlineFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGenericOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DA36 RID: 55862
		[DllImport("Kitware.VTK.FiltersGeneric.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGenericOutlineFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DA37 RID: 55863 RVA: 0x0012EDB8 File Offset: 0x0012CFB8
		public new static vtkGenericOutlineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkGenericOutlineFilter vtkGenericOutlineFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGenericOutlineFilter.vtkGenericOutlineFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGenericOutlineFilter = (vtkGenericOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGenericOutlineFilter.Register(null);
				}
			}
			return vtkGenericOutlineFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FE4 RID: 4068
		public new const string MRFullTypeName = "Kitware.VTK.vtkGenericOutlineFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FE5 RID: 4069
		public new static readonly string MRClassNameKey = "class vtkGenericOutlineFilter";
	}
}
