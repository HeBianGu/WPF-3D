using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLinearSubdivisionFilter
	/// </summary>
	/// <remarks>
	///    generate a subdivision surface using the Linear Scheme
	///
	/// vtkLinearSubdivisionFilter is a filter that generates output by
	/// subdividing its input polydata. Each subdivision iteration create 4
	/// new triangles for each triangle in the polydata.
	///
	/// @par Thanks:
	/// This work was supported by PHS Research Grant No. 1 P41 RR13218-01
	/// from the National Center for Research Resources.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkInterpolatingSubdivisionFilter vtkButterflySubdivisionFilter
	/// </seealso>
	// Token: 0x02000560 RID: 1376
	public class vtkLinearSubdivisionFilter : vtkInterpolatingSubdivisionFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F3E7 RID: 62439 RVA: 0x00153A47 File Offset: 0x00151C47
		static vtkLinearSubdivisionFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearSubdivisionFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearSubdivisionFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F3E8 RID: 62440 RVA: 0x00153A6F File Offset: 0x00151C6F
		public vtkLinearSubdivisionFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600F3E9 RID: 62441
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearSubdivisionFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F3EA RID: 62442 RVA: 0x00153A80 File Offset: 0x00151C80
		public new static vtkLinearSubdivisionFilter New()
		{
			vtkLinearSubdivisionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F3EB RID: 62443 RVA: 0x00153AD4 File Offset: 0x00151CD4
		public vtkLinearSubdivisionFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F3EC RID: 62444 RVA: 0x00153B18 File Offset: 0x00151D18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F3ED RID: 62445
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearSubdivisionFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F3EE RID: 62446 RVA: 0x00153B24 File Offset: 0x00151D24
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F3EF RID: 62447
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F3F0 RID: 62448 RVA: 0x00153B44 File Offset: 0x00151D44
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F3F1 RID: 62449
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearSubdivisionFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F3F2 RID: 62450 RVA: 0x00153B60 File Offset: 0x00151D60
		public override int IsA(string type)
		{
			return vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F3F3 RID: 62451
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearSubdivisionFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F3F4 RID: 62452 RVA: 0x00153B80 File Offset: 0x00151D80
		public new static int IsTypeOf(string type)
		{
			return vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_IsTypeOf_04(type);
		}

		// Token: 0x0600F3F5 RID: 62453
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearSubdivisionFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F3F6 RID: 62454 RVA: 0x00153B9C File Offset: 0x00151D9C
		public new vtkLinearSubdivisionFilter NewInstance()
		{
			vtkLinearSubdivisionFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F3F7 RID: 62455
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearSubdivisionFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with NumberOfSubdivisions set to 1.
		/// </summary>
		// Token: 0x0600F3F8 RID: 62456 RVA: 0x00153BF8 File Offset: 0x00151DF8
		public new static vtkLinearSubdivisionFilter SafeDownCast(vtkObjectBase o)
		{
			vtkLinearSubdivisionFilter vtkLinearSubdivisionFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearSubdivisionFilter.vtkLinearSubdivisionFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearSubdivisionFilter = (vtkLinearSubdivisionFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearSubdivisionFilter.Register(null);
				}
			}
			return vtkLinearSubdivisionFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011CB RID: 4555
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearSubdivisionFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040011CC RID: 4556
		public new static readonly string MRClassNameKey = "class vtkLinearSubdivisionFilter";
	}
}
