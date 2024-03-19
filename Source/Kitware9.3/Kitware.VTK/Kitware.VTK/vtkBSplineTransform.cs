using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkBSplineTransform
	/// </summary>
	/// <remarks>
	///    a cubic b-spline deformation transformation
	///
	/// vtkBSplineTransform computes a cubic b-spline transformation from a
	/// grid of b-spline coefficients.
	/// @warning
	/// The inverse grid transform is calculated using an iterative method,
	/// and is several times more expensive than the forward transform.
	/// </remarks>
	/// <seealso>
	///
	/// vtkGeneralTransform vtkTransformToGrid vtkImageBSplineCoefficients
	/// @par Thanks:
	/// This class was written by David Gobbi at the Seaman Family MR Research
	/// Centre, Foothills Medical Centre, Calgary, Alberta.
	/// DG Gobbi and YP Starreveld,
	/// "Uniform B-Splines for the VTK Imaging Pipeline,"
	/// VTK Journal, 2011,
	/// http://hdl.handle.net/10380/3252
	/// </seealso>
	// Token: 0x02000602 RID: 1538
	public class vtkBSplineTransform : vtkWarpTransform
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06010B56 RID: 68438 RVA: 0x00174DAD File Offset: 0x00172FAD
		static vtkBSplineTransform()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkBSplineTransform.MRClassNameKey, Type.GetType("Kitware.VTK.vtkBSplineTransform"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06010B57 RID: 68439 RVA: 0x00174DD5 File Offset: 0x00172FD5
		public vtkBSplineTransform(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06010B58 RID: 68440
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSplineTransform_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B59 RID: 68441 RVA: 0x00174DE4 File Offset: 0x00172FE4
		public new static vtkBSplineTransform New()
		{
			vtkBSplineTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSplineTransform.vtkBSplineTransform_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBSplineTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B5A RID: 68442 RVA: 0x00174E38 File Offset: 0x00173038
		public vtkBSplineTransform() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkBSplineTransform.vtkBSplineTransform_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06010B5B RID: 68443 RVA: 0x00174E7C File Offset: 0x0017307C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06010B5C RID: 68444
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSplineTransform_GetBorderMode_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the border mode, to alter behavior at the edge of the grid.
		/// The Edge mode allows the displacement to converge to the edge
		/// coefficient past the boundary, which is similar to the behavior of
		/// the vtkGridTransform. The Zero mode allows the displacement to
		/// smoothly converge to zero two node-spacings past the boundary,
		/// which is useful when you want to create a localized transform.
		/// The ZeroAtBorder mode sacrifices smoothness to further localize
		/// the transform to just one node-spacing past the boundary.
		/// </summary>
		// Token: 0x06010B5D RID: 68445 RVA: 0x00174E88 File Offset: 0x00173088
		public virtual int GetBorderMode()
		{
			return vtkBSplineTransform.vtkBSplineTransform_GetBorderMode_01(base.GetCppThis());
		}

		// Token: 0x06010B5E RID: 68446
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSplineTransform_GetBorderModeAsString_02(HandleRef pThis);

		/// <summary>
		/// Set/Get the border mode, to alter behavior at the edge of the grid.
		/// The Edge mode allows the displacement to converge to the edge
		/// coefficient past the boundary, which is similar to the behavior of
		/// the vtkGridTransform. The Zero mode allows the displacement to
		/// smoothly converge to zero two node-spacings past the boundary,
		/// which is useful when you want to create a localized transform.
		/// The ZeroAtBorder mode sacrifices smoothness to further localize
		/// the transform to just one node-spacing past the boundary.
		/// </summary>
		// Token: 0x06010B5F RID: 68447 RVA: 0x00174EA8 File Offset: 0x001730A8
		public string GetBorderModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkBSplineTransform.vtkBSplineTransform_GetBorderModeAsString_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06010B60 RID: 68448
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSplineTransform_GetBorderModeMaxValue_03(HandleRef pThis);

		/// <summary>
		/// Set/Get the border mode, to alter behavior at the edge of the grid.
		/// The Edge mode allows the displacement to converge to the edge
		/// coefficient past the boundary, which is similar to the behavior of
		/// the vtkGridTransform. The Zero mode allows the displacement to
		/// smoothly converge to zero two node-spacings past the boundary,
		/// which is useful when you want to create a localized transform.
		/// The ZeroAtBorder mode sacrifices smoothness to further localize
		/// the transform to just one node-spacing past the boundary.
		/// </summary>
		// Token: 0x06010B61 RID: 68449 RVA: 0x00174EE4 File Offset: 0x001730E4
		public virtual int GetBorderModeMaxValue()
		{
			return vtkBSplineTransform.vtkBSplineTransform_GetBorderModeMaxValue_03(base.GetCppThis());
		}

		// Token: 0x06010B62 RID: 68450
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSplineTransform_GetBorderModeMinValue_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the border mode, to alter behavior at the edge of the grid.
		/// The Edge mode allows the displacement to converge to the edge
		/// coefficient past the boundary, which is similar to the behavior of
		/// the vtkGridTransform. The Zero mode allows the displacement to
		/// smoothly converge to zero two node-spacings past the boundary,
		/// which is useful when you want to create a localized transform.
		/// The ZeroAtBorder mode sacrifices smoothness to further localize
		/// the transform to just one node-spacing past the boundary.
		/// </summary>
		// Token: 0x06010B63 RID: 68451 RVA: 0x00174F04 File Offset: 0x00173104
		public virtual int GetBorderModeMinValue()
		{
			return vtkBSplineTransform.vtkBSplineTransform_GetBorderModeMinValue_04(base.GetCppThis());
		}

		// Token: 0x06010B64 RID: 68452
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSplineTransform_GetCoefficientData_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/Get the coefficient grid for the b-spline transform.
		/// The vtkBSplineTransform class will never modify the data.
		/// Note that SetCoefficientData() does not setup a pipeline
		/// connection whereas SetCoefficientConnection does.
		/// </summary>
		// Token: 0x06010B65 RID: 68453 RVA: 0x00174F24 File Offset: 0x00173124
		public virtual vtkImageData GetCoefficientData()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSplineTransform.vtkBSplineTransform_GetCoefficientData_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06010B66 RID: 68454
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkBSplineTransform_GetDisplacementScale_06(HandleRef pThis);

		/// <summary>
		/// Set/Get a scale to apply to the transformation.
		/// </summary>
		// Token: 0x06010B67 RID: 68455 RVA: 0x00174F94 File Offset: 0x00173194
		public virtual double GetDisplacementScale()
		{
			return vtkBSplineTransform.vtkBSplineTransform_GetDisplacementScale_06(base.GetCppThis());
		}

		// Token: 0x06010B68 RID: 68456
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkBSplineTransform_GetMTime_07(HandleRef pThis);

		/// <summary>
		/// Get the MTime.
		/// </summary>
		// Token: 0x06010B69 RID: 68457 RVA: 0x00174FB4 File Offset: 0x001731B4
		public override ulong GetMTime()
		{
			return vtkBSplineTransform.vtkBSplineTransform_GetMTime_07(base.GetCppThis());
		}

		// Token: 0x06010B6A RID: 68458
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBSplineTransform_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B6B RID: 68459 RVA: 0x00174FD4 File Offset: 0x001731D4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkBSplineTransform.vtkBSplineTransform_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x06010B6C RID: 68460
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkBSplineTransform_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B6D RID: 68461 RVA: 0x00174FF4 File Offset: 0x001731F4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkBSplineTransform.vtkBSplineTransform_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x06010B6E RID: 68462
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSplineTransform_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B6F RID: 68463 RVA: 0x00175010 File Offset: 0x00173210
		public override int IsA(string type)
		{
			return vtkBSplineTransform.vtkBSplineTransform_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06010B70 RID: 68464
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkBSplineTransform_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B71 RID: 68465 RVA: 0x00175030 File Offset: 0x00173230
		public new static int IsTypeOf(string type)
		{
			return vtkBSplineTransform.vtkBSplineTransform_IsTypeOf_11(type);
		}

		// Token: 0x06010B72 RID: 68466
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSplineTransform_MakeTransform_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Make another transform of the same type.
		/// </summary>
		// Token: 0x06010B73 RID: 68467 RVA: 0x0017504C File Offset: 0x0017324C
		public override vtkAbstractTransform MakeTransform()
		{
			vtkAbstractTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSplineTransform.vtkBSplineTransform_MakeTransform_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010B74 RID: 68468
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSplineTransform_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B75 RID: 68469 RVA: 0x001750A8 File Offset: 0x001732A8
		public new vtkBSplineTransform NewInstance()
		{
			vtkBSplineTransform result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSplineTransform.vtkBSplineTransform_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkBSplineTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06010B76 RID: 68470
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkBSplineTransform_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06010B77 RID: 68471 RVA: 0x00175104 File Offset: 0x00173304
		public new static vtkBSplineTransform SafeDownCast(vtkObjectBase o)
		{
			vtkBSplineTransform vtkBSplineTransform = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkBSplineTransform.vtkBSplineTransform_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkBSplineTransform = (vtkBSplineTransform)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkBSplineTransform.Register(null);
				}
			}
			return vtkBSplineTransform;
		}

		// Token: 0x06010B78 RID: 68472
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSplineTransform_SetBorderMode_16(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get the border mode, to alter behavior at the edge of the grid.
		/// The Edge mode allows the displacement to converge to the edge
		/// coefficient past the boundary, which is similar to the behavior of
		/// the vtkGridTransform. The Zero mode allows the displacement to
		/// smoothly converge to zero two node-spacings past the boundary,
		/// which is useful when you want to create a localized transform.
		/// The ZeroAtBorder mode sacrifices smoothness to further localize
		/// the transform to just one node-spacing past the boundary.
		/// </summary>
		// Token: 0x06010B79 RID: 68473 RVA: 0x00175183 File Offset: 0x00173383
		public virtual void SetBorderMode(int _arg)
		{
			vtkBSplineTransform.vtkBSplineTransform_SetBorderMode_16(base.GetCppThis(), _arg);
		}

		// Token: 0x06010B7A RID: 68474
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSplineTransform_SetBorderModeToEdge_17(HandleRef pThis);

		/// <summary>
		/// Set/Get the border mode, to alter behavior at the edge of the grid.
		/// The Edge mode allows the displacement to converge to the edge
		/// coefficient past the boundary, which is similar to the behavior of
		/// the vtkGridTransform. The Zero mode allows the displacement to
		/// smoothly converge to zero two node-spacings past the boundary,
		/// which is useful when you want to create a localized transform.
		/// The ZeroAtBorder mode sacrifices smoothness to further localize
		/// the transform to just one node-spacing past the boundary.
		/// </summary>
		// Token: 0x06010B7B RID: 68475 RVA: 0x00175193 File Offset: 0x00173393
		public void SetBorderModeToEdge()
		{
			vtkBSplineTransform.vtkBSplineTransform_SetBorderModeToEdge_17(base.GetCppThis());
		}

		// Token: 0x06010B7C RID: 68476
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSplineTransform_SetBorderModeToZero_18(HandleRef pThis);

		/// <summary>
		/// Set/Get the border mode, to alter behavior at the edge of the grid.
		/// The Edge mode allows the displacement to converge to the edge
		/// coefficient past the boundary, which is similar to the behavior of
		/// the vtkGridTransform. The Zero mode allows the displacement to
		/// smoothly converge to zero two node-spacings past the boundary,
		/// which is useful when you want to create a localized transform.
		/// The ZeroAtBorder mode sacrifices smoothness to further localize
		/// the transform to just one node-spacing past the boundary.
		/// </summary>
		// Token: 0x06010B7D RID: 68477 RVA: 0x001751A2 File Offset: 0x001733A2
		public void SetBorderModeToZero()
		{
			vtkBSplineTransform.vtkBSplineTransform_SetBorderModeToZero_18(base.GetCppThis());
		}

		// Token: 0x06010B7E RID: 68478
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSplineTransform_SetBorderModeToZeroAtBorder_19(HandleRef pThis);

		/// <summary>
		/// Set/Get the border mode, to alter behavior at the edge of the grid.
		/// The Edge mode allows the displacement to converge to the edge
		/// coefficient past the boundary, which is similar to the behavior of
		/// the vtkGridTransform. The Zero mode allows the displacement to
		/// smoothly converge to zero two node-spacings past the boundary,
		/// which is useful when you want to create a localized transform.
		/// The ZeroAtBorder mode sacrifices smoothness to further localize
		/// the transform to just one node-spacing past the boundary.
		/// </summary>
		// Token: 0x06010B7F RID: 68479 RVA: 0x001751B1 File Offset: 0x001733B1
		public void SetBorderModeToZeroAtBorder()
		{
			vtkBSplineTransform.vtkBSplineTransform_SetBorderModeToZeroAtBorder_19(base.GetCppThis());
		}

		// Token: 0x06010B80 RID: 68480
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSplineTransform_SetCoefficientConnection_20(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the coefficient grid for the b-spline transform.
		/// The vtkBSplineTransform class will never modify the data.
		/// Note that SetCoefficientData() does not setup a pipeline
		/// connection whereas SetCoefficientConnection does.
		/// </summary>
		// Token: 0x06010B81 RID: 68481 RVA: 0x001751C0 File Offset: 0x001733C0
		public virtual void SetCoefficientConnection(vtkAlgorithmOutput arg0)
		{
			vtkBSplineTransform.vtkBSplineTransform_SetCoefficientConnection_20(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010B82 RID: 68482
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSplineTransform_SetCoefficientData_21(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/Get the coefficient grid for the b-spline transform.
		/// The vtkBSplineTransform class will never modify the data.
		/// Note that SetCoefficientData() does not setup a pipeline
		/// connection whereas SetCoefficientConnection does.
		/// </summary>
		// Token: 0x06010B83 RID: 68483 RVA: 0x001751F0 File Offset: 0x001733F0
		public virtual void SetCoefficientData(vtkImageData arg0)
		{
			vtkBSplineTransform.vtkBSplineTransform_SetCoefficientData_21(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06010B84 RID: 68484
		[DllImport("Kitware.VTK.FiltersHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkBSplineTransform_SetDisplacementScale_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get a scale to apply to the transformation.
		/// </summary>
		// Token: 0x06010B85 RID: 68485 RVA: 0x0017521F File Offset: 0x0017341F
		public virtual void SetDisplacementScale(double _arg)
		{
			vtkBSplineTransform.vtkBSplineTransform_SetDisplacementScale_22(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400135A RID: 4954
		public new const string MRFullTypeName = "Kitware.VTK.vtkBSplineTransform";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400135B RID: 4955
		public new static readonly string MRClassNameKey = "class vtkBSplineTransform";
	}
}
