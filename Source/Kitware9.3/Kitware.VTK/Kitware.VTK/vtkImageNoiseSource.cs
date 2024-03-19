using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageNoiseSource
	/// </summary>
	/// <remarks>
	///    Create an image filled with noise.
	///
	/// vtkImageNoiseSource just produces images filled with noise.  The only
	/// option now is uniform noise specified by a min and a max.  There is one
	/// major problem with this source. Every time it executes, it will output
	/// different pixel values.  This has important implications when a stream
	/// requests overlapping regions.  The same pixels will have different values
	/// on different updates.
	/// </remarks>
	// Token: 0x02000759 RID: 1881
	public class vtkImageNoiseSource : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060138A1 RID: 80033 RVA: 0x001B9C5D File Offset: 0x001B7E5D
		static vtkImageNoiseSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageNoiseSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageNoiseSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060138A2 RID: 80034 RVA: 0x001B9C85 File Offset: 0x001B7E85
		public vtkImageNoiseSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060138A3 RID: 80035
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageNoiseSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138A4 RID: 80036 RVA: 0x001B9C94 File Offset: 0x001B7E94
		public new static vtkImageNoiseSource New()
		{
			vtkImageNoiseSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageNoiseSource.vtkImageNoiseSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageNoiseSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138A5 RID: 80037 RVA: 0x001B9CE8 File Offset: 0x001B7EE8
		public vtkImageNoiseSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageNoiseSource.vtkImageNoiseSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060138A6 RID: 80038 RVA: 0x001B9D2C File Offset: 0x001B7F2C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060138A7 RID: 80039
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageNoiseSource_GetMaximum_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum and maximum values for the generated noise.
		/// </summary>
		// Token: 0x060138A8 RID: 80040 RVA: 0x001B9D38 File Offset: 0x001B7F38
		public virtual double GetMaximum()
		{
			return vtkImageNoiseSource.vtkImageNoiseSource_GetMaximum_01(base.GetCppThis());
		}

		// Token: 0x060138A9 RID: 80041
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageNoiseSource_GetMinimum_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the minimum and maximum values for the generated noise.
		/// </summary>
		// Token: 0x060138AA RID: 80042 RVA: 0x001B9D58 File Offset: 0x001B7F58
		public virtual double GetMinimum()
		{
			return vtkImageNoiseSource.vtkImageNoiseSource_GetMinimum_02(base.GetCppThis());
		}

		// Token: 0x060138AB RID: 80043
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageNoiseSource_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138AC RID: 80044 RVA: 0x001B9D78 File Offset: 0x001B7F78
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageNoiseSource.vtkImageNoiseSource_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060138AD RID: 80045
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageNoiseSource_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138AE RID: 80046 RVA: 0x001B9D98 File Offset: 0x001B7F98
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageNoiseSource.vtkImageNoiseSource_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060138AF RID: 80047
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageNoiseSource_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138B0 RID: 80048 RVA: 0x001B9DB4 File Offset: 0x001B7FB4
		public override int IsA(string type)
		{
			return vtkImageNoiseSource.vtkImageNoiseSource_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060138B1 RID: 80049
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageNoiseSource_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138B2 RID: 80050 RVA: 0x001B9DD4 File Offset: 0x001B7FD4
		public new static int IsTypeOf(string type)
		{
			return vtkImageNoiseSource.vtkImageNoiseSource_IsTypeOf_06(type);
		}

		// Token: 0x060138B3 RID: 80051
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageNoiseSource_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138B4 RID: 80052 RVA: 0x001B9DF0 File Offset: 0x001B7FF0
		public new vtkImageNoiseSource NewInstance()
		{
			vtkImageNoiseSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageNoiseSource.vtkImageNoiseSource_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageNoiseSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060138B5 RID: 80053
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageNoiseSource_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060138B6 RID: 80054 RVA: 0x001B9E4C File Offset: 0x001B804C
		public new static vtkImageNoiseSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageNoiseSource vtkImageNoiseSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageNoiseSource.vtkImageNoiseSource_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageNoiseSource = (vtkImageNoiseSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageNoiseSource.Register(null);
				}
			}
			return vtkImageNoiseSource;
		}

		// Token: 0x060138B7 RID: 80055
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageNoiseSource_SetMaximum_10(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the minimum and maximum values for the generated noise.
		/// </summary>
		// Token: 0x060138B8 RID: 80056 RVA: 0x001B9ECB File Offset: 0x001B80CB
		public virtual void SetMaximum(double _arg)
		{
			vtkImageNoiseSource.vtkImageNoiseSource_SetMaximum_10(base.GetCppThis(), _arg);
		}

		// Token: 0x060138B9 RID: 80057
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageNoiseSource_SetMinimum_11(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the minimum and maximum values for the generated noise.
		/// </summary>
		// Token: 0x060138BA RID: 80058 RVA: 0x001B9EDB File Offset: 0x001B80DB
		public virtual void SetMinimum(double _arg)
		{
			vtkImageNoiseSource.vtkImageNoiseSource_SetMinimum_11(base.GetCppThis(), _arg);
		}

		// Token: 0x060138BB RID: 80059
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageNoiseSource_SetWholeExtent_12(HandleRef pThis, int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax);

		/// <summary>
		/// Set how large of an image to generate.
		/// </summary>
		// Token: 0x060138BC RID: 80060 RVA: 0x001B9EEB File Offset: 0x001B80EB
		public void SetWholeExtent(int xMinx, int xMax, int yMin, int yMax, int zMin, int zMax)
		{
			vtkImageNoiseSource.vtkImageNoiseSource_SetWholeExtent_12(base.GetCppThis(), xMinx, xMax, yMin, yMax, zMin, zMax);
		}

		// Token: 0x060138BD RID: 80061
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageNoiseSource_SetWholeExtent_13(HandleRef pThis, IntPtr ext);

		/// <summary>
		/// Set how large of an image to generate.
		/// </summary>
		// Token: 0x060138BE RID: 80062 RVA: 0x001B9F03 File Offset: 0x001B8103
		public void SetWholeExtent(IntPtr ext)
		{
			vtkImageNoiseSource.vtkImageNoiseSource_SetWholeExtent_13(base.GetCppThis(), ext);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400168F RID: 5775
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageNoiseSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001690 RID: 5776
		public new static readonly string MRClassNameKey = "class vtkImageNoiseSource";
	}
}
