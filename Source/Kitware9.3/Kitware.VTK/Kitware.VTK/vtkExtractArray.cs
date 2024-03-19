using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractArray
	/// </summary>
	/// <remarks>
	///    Given a vtkArrayData object containing one-or-more
	/// vtkArray instances, produces a vtkArrayData containing just one vtkArray,
	/// identified by index.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x0200089C RID: 2204
	public class vtkExtractArray : vtkArrayDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016E3D RID: 93757 RVA: 0x00202A47 File Offset: 0x00200C47
		static vtkExtractArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016E3E RID: 93758 RVA: 0x00202A6F File Offset: 0x00200C6F
		public vtkExtractArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016E3F RID: 93759
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E40 RID: 93760 RVA: 0x00202A80 File Offset: 0x00200C80
		public new static vtkExtractArray New()
		{
			vtkExtractArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractArray.vtkExtractArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E41 RID: 93761 RVA: 0x00202AD4 File Offset: 0x00200CD4
		public vtkExtractArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractArray.vtkExtractArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016E42 RID: 93762 RVA: 0x00202B18 File Offset: 0x00200D18
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016E43 RID: 93763
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractArray_GetIndex_01(HandleRef pThis);

		/// <summary>
		/// Controls which array will be extracted.
		/// </summary>
		// Token: 0x06016E44 RID: 93764 RVA: 0x00202B24 File Offset: 0x00200D24
		public virtual long GetIndex()
		{
			return vtkExtractArray.vtkExtractArray_GetIndex_01(base.GetCppThis());
		}

		// Token: 0x06016E45 RID: 93765
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractArray_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E46 RID: 93766 RVA: 0x00202B44 File Offset: 0x00200D44
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractArray.vtkExtractArray_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06016E47 RID: 93767
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractArray_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E48 RID: 93768 RVA: 0x00202B64 File Offset: 0x00200D64
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractArray.vtkExtractArray_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06016E49 RID: 93769
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractArray_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E4A RID: 93770 RVA: 0x00202B80 File Offset: 0x00200D80
		public override int IsA(string type)
		{
			return vtkExtractArray.vtkExtractArray_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016E4B RID: 93771
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractArray_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E4C RID: 93772 RVA: 0x00202BA0 File Offset: 0x00200DA0
		public new static int IsTypeOf(string type)
		{
			return vtkExtractArray.vtkExtractArray_IsTypeOf_05(type);
		}

		// Token: 0x06016E4D RID: 93773
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractArray_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E4E RID: 93774 RVA: 0x00202BBC File Offset: 0x00200DBC
		public new vtkExtractArray NewInstance()
		{
			vtkExtractArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractArray.vtkExtractArray_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016E4F RID: 93775
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractArray_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016E50 RID: 93776 RVA: 0x00202C18 File Offset: 0x00200E18
		public new static vtkExtractArray SafeDownCast(vtkObjectBase o)
		{
			vtkExtractArray vtkExtractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractArray.vtkExtractArray_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractArray = (vtkExtractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractArray.Register(null);
				}
			}
			return vtkExtractArray;
		}

		// Token: 0x06016E51 RID: 93777
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractArray_SetIndex_09(HandleRef pThis, long _arg);

		/// <summary>
		/// Controls which array will be extracted.
		/// </summary>
		// Token: 0x06016E52 RID: 93778 RVA: 0x00202C97 File Offset: 0x00200E97
		public virtual void SetIndex(long _arg)
		{
			vtkExtractArray.vtkExtractArray_SetIndex_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001999 RID: 6553
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400199A RID: 6554
		public new static readonly string MRClassNameKey = "class vtkExtractArray";
	}
}
