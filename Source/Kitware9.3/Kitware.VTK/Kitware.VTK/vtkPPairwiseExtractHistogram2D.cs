using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPPairwiseExtractHistogram2D
	/// </summary>
	/// <remarks>
	///    compute a 2D histogram between
	///  all adjacent columns of an input vtkTable in parallel.
	///
	///
	///  This class does exactly the same this as vtkPairwiseExtractHistogram2D,
	///  but does it in a multi-process environment.  After each node
	///  computes their own local histograms, this class does an AllReduce
	///  that distributes the sum of all local histograms onto each node.
	///
	///  Because vtkPairwiseExtractHistogram2D is a light wrapper around a series
	///  of vtkExtractHistogram2D classes, this class just overrides the function
	///  that instantiates new histogram filters and returns the parallel version
	///  (vtkPExtractHistogram2D).
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkExtractHistogram2D vtkPairwiseExtractHistogram2D vtkPExtractHistogram2D
	///
	/// @par Thanks:
	///  Developed by David Feng and Philippe Pebay at Sandia National Laboratories
	///             ------------------------------------------------------------------------------
	/// </seealso>
	// Token: 0x0200047A RID: 1146
	public class vtkPPairwiseExtractHistogram2D : vtkPairwiseExtractHistogram2D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D341 RID: 54081 RVA: 0x00125FC4 File Offset: 0x001241C4
		static vtkPPairwiseExtractHistogram2D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPPairwiseExtractHistogram2D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPPairwiseExtractHistogram2D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D342 RID: 54082 RVA: 0x00125FEC File Offset: 0x001241EC
		public vtkPPairwiseExtractHistogram2D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D343 RID: 54083
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPPairwiseExtractHistogram2D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D344 RID: 54084 RVA: 0x00125FFC File Offset: 0x001241FC
		public new static vtkPPairwiseExtractHistogram2D New()
		{
			vtkPPairwiseExtractHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D345 RID: 54085 RVA: 0x00126050 File Offset: 0x00124250
		public vtkPPairwiseExtractHistogram2D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D346 RID: 54086 RVA: 0x00126094 File Offset: 0x00124294
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D347 RID: 54087
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPPairwiseExtractHistogram2D_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D348 RID: 54088 RVA: 0x001260A0 File Offset: 0x001242A0
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600D349 RID: 54089
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D34A RID: 54090 RVA: 0x00126110 File Offset: 0x00124310
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600D34B RID: 54091
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D34C RID: 54092 RVA: 0x00126130 File Offset: 0x00124330
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600D34D RID: 54093
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPPairwiseExtractHistogram2D_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D34E RID: 54094 RVA: 0x0012614C File Offset: 0x0012434C
		public override int IsA(string type)
		{
			return vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600D34F RID: 54095
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPPairwiseExtractHistogram2D_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D350 RID: 54096 RVA: 0x0012616C File Offset: 0x0012436C
		public new static int IsTypeOf(string type)
		{
			return vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_IsTypeOf_05(type);
		}

		// Token: 0x0600D351 RID: 54097
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPPairwiseExtractHistogram2D_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D352 RID: 54098 RVA: 0x00126188 File Offset: 0x00124388
		public new vtkPPairwiseExtractHistogram2D NewInstance()
		{
			vtkPPairwiseExtractHistogram2D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D353 RID: 54099
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPPairwiseExtractHistogram2D_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D354 RID: 54100 RVA: 0x001261E4 File Offset: 0x001243E4
		public new static vtkPPairwiseExtractHistogram2D SafeDownCast(vtkObjectBase o)
		{
			vtkPPairwiseExtractHistogram2D vtkPPairwiseExtractHistogram2D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPPairwiseExtractHistogram2D = (vtkPPairwiseExtractHistogram2D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPPairwiseExtractHistogram2D.Register(null);
				}
			}
			return vtkPPairwiseExtractHistogram2D;
		}

		// Token: 0x0600D355 RID: 54101
		[DllImport("Kitware.VTK.FiltersParallelImaging.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPPairwiseExtractHistogram2D_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D356 RID: 54102 RVA: 0x00126264 File Offset: 0x00124464
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPPairwiseExtractHistogram2D.vtkPPairwiseExtractHistogram2D_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F9C RID: 3996
		public new const string MRFullTypeName = "Kitware.VTK.vtkPPairwiseExtractHistogram2D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F9D RID: 3997
		public new static readonly string MRClassNameKey = "class vtkPPairwiseExtractHistogram2D";
	}
}
