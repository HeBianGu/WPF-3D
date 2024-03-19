using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMatricizeArray
	/// </summary>
	/// <remarks>
	///    Convert an array of arbitrary dimensions to a
	/// matrix.
	///
	///
	/// Given a sparse input array of arbitrary dimension, creates a sparse output
	/// matrix (vtkSparseArray&lt;double&gt;) where each column is a slice along an
	/// arbitrary dimension from the source.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x020008B9 RID: 2233
	public class vtkMatricizeArray : vtkArrayDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017244 RID: 94788 RVA: 0x00207C52 File Offset: 0x00205E52
		static vtkMatricizeArray()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMatricizeArray.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMatricizeArray"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017245 RID: 94789 RVA: 0x00207C7A File Offset: 0x00205E7A
		public vtkMatricizeArray(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017246 RID: 94790
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatricizeArray_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017247 RID: 94791 RVA: 0x00207C88 File Offset: 0x00205E88
		public new static vtkMatricizeArray New()
		{
			vtkMatricizeArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatricizeArray.vtkMatricizeArray_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatricizeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017248 RID: 94792 RVA: 0x00207CDC File Offset: 0x00205EDC
		public vtkMatricizeArray() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMatricizeArray.vtkMatricizeArray_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017249 RID: 94793 RVA: 0x00207D20 File Offset: 0x00205F20
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601724A RID: 94794
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatricizeArray_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601724B RID: 94795 RVA: 0x00207D2C File Offset: 0x00205F2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMatricizeArray.vtkMatricizeArray_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601724C RID: 94796
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatricizeArray_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601724D RID: 94797 RVA: 0x00207D4C File Offset: 0x00205F4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMatricizeArray.vtkMatricizeArray_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601724E RID: 94798
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMatricizeArray_GetSliceDimension_03(HandleRef pThis);

		/// <summary>
		/// Returns the 0-numbered dimension that will be mapped to columns in the output
		/// </summary>
		// Token: 0x0601724F RID: 94799 RVA: 0x00207D68 File Offset: 0x00205F68
		public virtual long GetSliceDimension()
		{
			return vtkMatricizeArray.vtkMatricizeArray_GetSliceDimension_03(base.GetCppThis());
		}

		// Token: 0x06017250 RID: 94800
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatricizeArray_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017251 RID: 94801 RVA: 0x00207D88 File Offset: 0x00205F88
		public override int IsA(string type)
		{
			return vtkMatricizeArray.vtkMatricizeArray_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06017252 RID: 94802
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMatricizeArray_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017253 RID: 94803 RVA: 0x00207DA8 File Offset: 0x00205FA8
		public new static int IsTypeOf(string type)
		{
			return vtkMatricizeArray.vtkMatricizeArray_IsTypeOf_05(type);
		}

		// Token: 0x06017254 RID: 94804
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatricizeArray_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017255 RID: 94805 RVA: 0x00207DC4 File Offset: 0x00205FC4
		public new vtkMatricizeArray NewInstance()
		{
			vtkMatricizeArray result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatricizeArray.vtkMatricizeArray_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMatricizeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017256 RID: 94806
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMatricizeArray_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017257 RID: 94807 RVA: 0x00207E20 File Offset: 0x00206020
		public new static vtkMatricizeArray SafeDownCast(vtkObjectBase o)
		{
			vtkMatricizeArray vtkMatricizeArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMatricizeArray.vtkMatricizeArray_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMatricizeArray = (vtkMatricizeArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMatricizeArray.Register(null);
				}
			}
			return vtkMatricizeArray;
		}

		// Token: 0x06017258 RID: 94808
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMatricizeArray_SetSliceDimension_09(HandleRef pThis, long _arg);

		/// <summary>
		/// Sets the 0-numbered dimension that will be mapped to columns in the output
		/// </summary>
		// Token: 0x06017259 RID: 94809 RVA: 0x00207E9F File Offset: 0x0020609F
		public virtual void SetSliceDimension(long _arg)
		{
			vtkMatricizeArray.vtkMatricizeArray_SetSliceDimension_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019E0 RID: 6624
		public new const string MRFullTypeName = "Kitware.VTK.vtkMatricizeArray";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019E1 RID: 6625
		public new static readonly string MRClassNameKey = "class vtkMatricizeArray";
	}
}
