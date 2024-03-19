using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLinearKernel
	/// </summary>
	/// <remarks>
	///    a linear interpolation kernel
	///
	///
	/// vtkLinearKernel is an interpolation kernel that averages the contributions
	/// of all points in the basis.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointInterpolator vtkInterpolationKernel vtkGeneralizedKernel
	/// vtkGaussianKernel vtkLinearKernel vtkShepardKernel
	/// </seealso>
	// Token: 0x02000447 RID: 1095
	public class vtkLinearKernel : vtkGeneralizedKernel
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600CC5D RID: 52317 RVA: 0x0011C4F1 File Offset: 0x0011A6F1
		static vtkLinearKernel()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLinearKernel.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLinearKernel"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600CC5E RID: 52318 RVA: 0x0011C519 File Offset: 0x0011A719
		public vtkLinearKernel(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600CC5F RID: 52319
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearKernel_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC60 RID: 52320 RVA: 0x0011C528 File Offset: 0x0011A728
		public new static vtkLinearKernel New()
		{
			vtkLinearKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearKernel.vtkLinearKernel_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC61 RID: 52321 RVA: 0x0011C57C File Offset: 0x0011A77C
		public vtkLinearKernel() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLinearKernel.vtkLinearKernel_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600CC62 RID: 52322 RVA: 0x0011C5C0 File Offset: 0x0011A7C0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600CC63 RID: 52323
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearKernel_ComputeWeights_01(HandleRef pThis, IntPtr x, HandleRef pIds, HandleRef prob, HandleRef weights);

		/// <summary>
		/// Given a point x, a list of basis points pIds, and a probability
		/// weighting function prob, compute interpolation weights associated with
		/// these basis points.  Note that basis points list pIds, the probability
		/// weighting prob, and the weights array are provided by the caller of the
		/// method, and may be dynamically resized as necessary. The method returns
		/// the number of weights (pIds may be resized in some cases). Typically
		/// this method is called after ComputeBasis(), although advanced users can
		/// invoke ComputeWeights() and provide the interpolation basis points pIds
		/// directly. The probably weighting prob are numbers 0&lt;=prob&lt;=1 which are
		/// multiplied against the interpolation weights before normalization. They
		/// are estimates of local confidence of weights. The prob may be nullptr in
		/// which all probabilities are considered =1.
		/// </summary>
		// Token: 0x0600CC64 RID: 52324 RVA: 0x0011C5CC File Offset: 0x0011A7CC
		public override long ComputeWeights(IntPtr x, vtkIdList pIds, vtkDoubleArray prob, vtkDoubleArray weights)
		{
			return vtkLinearKernel.vtkLinearKernel_ComputeWeights_01(base.GetCppThis(), x, (pIds == null) ? default(HandleRef) : pIds.GetCppThis(), (prob == null) ? default(HandleRef) : prob.GetCppThis(), (weights == null) ? default(HandleRef) : weights.GetCppThis());
		}

		// Token: 0x0600CC65 RID: 52325
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearKernel_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC66 RID: 52326 RVA: 0x0011C630 File Offset: 0x0011A830
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLinearKernel.vtkLinearKernel_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600CC67 RID: 52327
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLinearKernel_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC68 RID: 52328 RVA: 0x0011C650 File Offset: 0x0011A850
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLinearKernel.vtkLinearKernel_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600CC69 RID: 52329
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearKernel_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC6A RID: 52330 RVA: 0x0011C66C File Offset: 0x0011A86C
		public override int IsA(string type)
		{
			return vtkLinearKernel.vtkLinearKernel_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600CC6B RID: 52331
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLinearKernel_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC6C RID: 52332 RVA: 0x0011C68C File Offset: 0x0011A88C
		public new static int IsTypeOf(string type)
		{
			return vtkLinearKernel.vtkLinearKernel_IsTypeOf_05(type);
		}

		// Token: 0x0600CC6D RID: 52333
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearKernel_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC6E RID: 52334 RVA: 0x0011C6A8 File Offset: 0x0011A8A8
		public new vtkLinearKernel NewInstance()
		{
			vtkLinearKernel result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearKernel.vtkLinearKernel_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLinearKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600CC6F RID: 52335
		[DllImport("Kitware.VTK.FiltersPoints.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLinearKernel_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for instantiation, obtaining type information, and printing.
		/// </summary>
		// Token: 0x0600CC70 RID: 52336 RVA: 0x0011C704 File Offset: 0x0011A904
		public new static vtkLinearKernel SafeDownCast(vtkObjectBase o)
		{
			vtkLinearKernel vtkLinearKernel = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLinearKernel.vtkLinearKernel_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLinearKernel = (vtkLinearKernel)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLinearKernel.Register(null);
				}
			}
			return vtkLinearKernel;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F1B RID: 3867
		public new const string MRFullTypeName = "Kitware.VTK.vtkLinearKernel";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F1C RID: 3868
		public new static readonly string MRClassNameKey = "class vtkLinearKernel";
	}
}
