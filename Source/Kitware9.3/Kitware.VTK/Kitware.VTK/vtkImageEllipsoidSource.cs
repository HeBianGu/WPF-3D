using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageEllipsoidSource
	/// </summary>
	/// <remarks>
	///    Create a binary image of an ellipsoid.
	///
	/// vtkImageEllipsoidSource creates a binary image of a ellipsoid.  It was created
	/// as an example of a simple source, and to test the mask filter.
	/// It is also used internally in vtkImageDilateErode3D.
	/// </remarks>
	// Token: 0x02000755 RID: 1877
	public class vtkImageEllipsoidSource : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013773 RID: 79731 RVA: 0x001B87C6 File Offset: 0x001B69C6
		static vtkImageEllipsoidSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageEllipsoidSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageEllipsoidSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013774 RID: 79732 RVA: 0x001B87EE File Offset: 0x001B69EE
		public vtkImageEllipsoidSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013775 RID: 79733
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEllipsoidSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013776 RID: 79734 RVA: 0x001B87FC File Offset: 0x001B69FC
		public new static vtkImageEllipsoidSource New()
		{
			vtkImageEllipsoidSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEllipsoidSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013777 RID: 79735 RVA: 0x001B8850 File Offset: 0x001B6A50
		public vtkImageEllipsoidSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageEllipsoidSource.vtkImageEllipsoidSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013778 RID: 79736 RVA: 0x001B8894 File Offset: 0x001B6A94
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013779 RID: 79737
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEllipsoidSource_GetCenter_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the center of the ellipsoid.
		/// </summary>
		// Token: 0x0601377A RID: 79738 RVA: 0x001B88A0 File Offset: 0x001B6AA0
		public virtual double[] GetCenter()
		{
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetCenter_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601377B RID: 79739
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_GetCenter_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the center of the ellipsoid.
		/// </summary>
		// Token: 0x0601377C RID: 79740 RVA: 0x001B88E8 File Offset: 0x001B6AE8
		public virtual void GetCenter(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetCenter_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601377D RID: 79741
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_GetCenter_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the center of the ellipsoid.
		/// </summary>
		// Token: 0x0601377E RID: 79742 RVA: 0x001B88FA File Offset: 0x001B6AFA
		public virtual void GetCenter(IntPtr _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetCenter_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0601377F RID: 79743
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageEllipsoidSource_GetInValue_04(HandleRef pThis);

		/// <summary>
		/// Set/Get the inside pixel values.
		/// </summary>
		// Token: 0x06013780 RID: 79744 RVA: 0x001B890C File Offset: 0x001B6B0C
		public virtual double GetInValue()
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetInValue_04(base.GetCppThis());
		}

		// Token: 0x06013781 RID: 79745
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageEllipsoidSource_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013782 RID: 79746 RVA: 0x001B892C File Offset: 0x001B6B2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06013783 RID: 79747
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageEllipsoidSource_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013784 RID: 79748 RVA: 0x001B894C File Offset: 0x001B6B4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x06013785 RID: 79749
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageEllipsoidSource_GetOutValue_07(HandleRef pThis);

		/// <summary>
		/// Set/Get the outside pixel values.
		/// </summary>
		// Token: 0x06013786 RID: 79750 RVA: 0x001B8968 File Offset: 0x001B6B68
		public virtual double GetOutValue()
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetOutValue_07(base.GetCppThis());
		}

		// Token: 0x06013787 RID: 79751
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageEllipsoidSource_GetOutputScalarType_08(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x06013788 RID: 79752 RVA: 0x001B8988 File Offset: 0x001B6B88
		public virtual int GetOutputScalarType()
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetOutputScalarType_08(base.GetCppThis());
		}

		// Token: 0x06013789 RID: 79753
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEllipsoidSource_GetRadius_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the radius of the ellipsoid.
		/// </summary>
		// Token: 0x0601378A RID: 79754 RVA: 0x001B89A8 File Offset: 0x001B6BA8
		public virtual double[] GetRadius()
		{
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetRadius_09(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601378B RID: 79755
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_GetRadius_10(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		/// Set/Get the radius of the ellipsoid.
		/// </summary>
		// Token: 0x0601378C RID: 79756 RVA: 0x001B89F0 File Offset: 0x001B6BF0
		public virtual void GetRadius(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetRadius_10(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0601378D RID: 79757
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_GetRadius_11(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the radius of the ellipsoid.
		/// </summary>
		// Token: 0x0601378E RID: 79758 RVA: 0x001B8A02 File Offset: 0x001B6C02
		public virtual void GetRadius(IntPtr _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetRadius_11(base.GetCppThis(), _arg);
		}

		// Token: 0x0601378F RID: 79759
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_GetWholeExtent_12(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set/Get the extent of the whole output image.
		/// </summary>
		// Token: 0x06013790 RID: 79760 RVA: 0x001B8A12 File Offset: 0x001B6C12
		public void GetWholeExtent(IntPtr extent)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetWholeExtent_12(base.GetCppThis(), extent);
		}

		// Token: 0x06013791 RID: 79761
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEllipsoidSource_GetWholeExtent_13(HandleRef pThis);

		/// <summary>
		/// Set/Get the extent of the whole output image.
		/// </summary>
		// Token: 0x06013792 RID: 79762 RVA: 0x001B8A24 File Offset: 0x001B6C24
		public int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_GetWholeExtent_13(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013793 RID: 79763
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageEllipsoidSource_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013794 RID: 79764 RVA: 0x001B8A6C File Offset: 0x001B6C6C
		public override int IsA(string type)
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06013795 RID: 79765
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageEllipsoidSource_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013796 RID: 79766 RVA: 0x001B8A8C File Offset: 0x001B6C8C
		public new static int IsTypeOf(string type)
		{
			return vtkImageEllipsoidSource.vtkImageEllipsoidSource_IsTypeOf_15(type);
		}

		// Token: 0x06013797 RID: 79767
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEllipsoidSource_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013798 RID: 79768 RVA: 0x001B8AA8 File Offset: 0x001B6CA8
		public new vtkImageEllipsoidSource NewInstance()
		{
			vtkImageEllipsoidSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageEllipsoidSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013799 RID: 79769
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageEllipsoidSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601379A RID: 79770 RVA: 0x001B8B04 File Offset: 0x001B6D04
		public new static vtkImageEllipsoidSource SafeDownCast(vtkObjectBase o)
		{
			vtkImageEllipsoidSource vtkImageEllipsoidSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageEllipsoidSource.vtkImageEllipsoidSource_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageEllipsoidSource = (vtkImageEllipsoidSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageEllipsoidSource.Register(null);
				}
			}
			return vtkImageEllipsoidSource;
		}

		// Token: 0x0601379B RID: 79771
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetCenter_19(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the center of the ellipsoid.
		/// </summary>
		// Token: 0x0601379C RID: 79772 RVA: 0x001B8B83 File Offset: 0x001B6D83
		public virtual void SetCenter(double _arg1, double _arg2, double _arg3)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetCenter_19(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0601379D RID: 79773
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetCenter_20(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the center of the ellipsoid.
		/// </summary>
		// Token: 0x0601379E RID: 79774 RVA: 0x001B8B95 File Offset: 0x001B6D95
		public virtual void SetCenter(IntPtr _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetCenter_20(base.GetCppThis(), _arg);
		}

		// Token: 0x0601379F RID: 79775
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetInValue_21(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the inside pixel values.
		/// </summary>
		// Token: 0x060137A0 RID: 79776 RVA: 0x001B8BA5 File Offset: 0x001B6DA5
		public virtual void SetInValue(double _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetInValue_21(base.GetCppThis(), _arg);
		}

		// Token: 0x060137A1 RID: 79777
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutValue_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the outside pixel values.
		/// </summary>
		// Token: 0x060137A2 RID: 79778 RVA: 0x001B8BB5 File Offset: 0x001B6DB5
		public virtual void SetOutValue(double _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutValue_22(base.GetCppThis(), _arg);
		}

		// Token: 0x060137A3 RID: 79779
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarType_23(HandleRef pThis, int _arg);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x060137A4 RID: 79780 RVA: 0x001B8BC5 File Offset: 0x001B6DC5
		public virtual void SetOutputScalarType(int _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarType_23(base.GetCppThis(), _arg);
		}

		// Token: 0x060137A5 RID: 79781
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToChar_24(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x060137A6 RID: 79782 RVA: 0x001B8BD5 File Offset: 0x001B6DD5
		public void SetOutputScalarTypeToChar()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToChar_24(base.GetCppThis());
		}

		// Token: 0x060137A7 RID: 79783
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToDouble_25(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x060137A8 RID: 79784 RVA: 0x001B8BE4 File Offset: 0x001B6DE4
		public void SetOutputScalarTypeToDouble()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToDouble_25(base.GetCppThis());
		}

		// Token: 0x060137A9 RID: 79785
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToFloat_26(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x060137AA RID: 79786 RVA: 0x001B8BF3 File Offset: 0x001B6DF3
		public void SetOutputScalarTypeToFloat()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToFloat_26(base.GetCppThis());
		}

		// Token: 0x060137AB RID: 79787
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToInt_27(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x060137AC RID: 79788 RVA: 0x001B8C02 File Offset: 0x001B6E02
		public void SetOutputScalarTypeToInt()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToInt_27(base.GetCppThis());
		}

		// Token: 0x060137AD RID: 79789
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToLong_28(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x060137AE RID: 79790 RVA: 0x001B8C11 File Offset: 0x001B6E11
		public void SetOutputScalarTypeToLong()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToLong_28(base.GetCppThis());
		}

		// Token: 0x060137AF RID: 79791
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToShort_29(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x060137B0 RID: 79792 RVA: 0x001B8C20 File Offset: 0x001B6E20
		public void SetOutputScalarTypeToShort()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToShort_29(base.GetCppThis());
		}

		// Token: 0x060137B1 RID: 79793
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedChar_30(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x060137B2 RID: 79794 RVA: 0x001B8C2F File Offset: 0x001B6E2F
		public void SetOutputScalarTypeToUnsignedChar()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedChar_30(base.GetCppThis());
		}

		// Token: 0x060137B3 RID: 79795
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedInt_31(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x060137B4 RID: 79796 RVA: 0x001B8C3E File Offset: 0x001B6E3E
		public void SetOutputScalarTypeToUnsignedInt()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedInt_31(base.GetCppThis());
		}

		// Token: 0x060137B5 RID: 79797
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedLong_32(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x060137B6 RID: 79798 RVA: 0x001B8C4D File Offset: 0x001B6E4D
		public void SetOutputScalarTypeToUnsignedLong()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedLong_32(base.GetCppThis());
		}

		// Token: 0x060137B7 RID: 79799
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedShort_33(HandleRef pThis);

		/// <summary>
		/// Set what type of scalar data this source should generate.
		/// </summary>
		// Token: 0x060137B8 RID: 79800 RVA: 0x001B8C5C File Offset: 0x001B6E5C
		public void SetOutputScalarTypeToUnsignedShort()
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetOutputScalarTypeToUnsignedShort_33(base.GetCppThis());
		}

		// Token: 0x060137B9 RID: 79801
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetRadius_34(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set/Get the radius of the ellipsoid.
		/// </summary>
		// Token: 0x060137BA RID: 79802 RVA: 0x001B8C6B File Offset: 0x001B6E6B
		public virtual void SetRadius(double _arg1, double _arg2, double _arg3)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetRadius_34(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x060137BB RID: 79803
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetRadius_35(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the radius of the ellipsoid.
		/// </summary>
		// Token: 0x060137BC RID: 79804 RVA: 0x001B8C7D File Offset: 0x001B6E7D
		public virtual void SetRadius(IntPtr _arg)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetRadius_35(base.GetCppThis(), _arg);
		}

		// Token: 0x060137BD RID: 79805
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetWholeExtent_36(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// Set/Get the extent of the whole output image.
		/// </summary>
		// Token: 0x060137BE RID: 79806 RVA: 0x001B8C8D File Offset: 0x001B6E8D
		public void SetWholeExtent(IntPtr extent)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetWholeExtent_36(base.GetCppThis(), extent);
		}

		// Token: 0x060137BF RID: 79807
		[DllImport("Kitware.VTK.ImagingSources.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageEllipsoidSource_SetWholeExtent_37(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		/// <summary>
		/// Set/Get the extent of the whole output image.
		/// </summary>
		// Token: 0x060137C0 RID: 79808 RVA: 0x001B8C9D File Offset: 0x001B6E9D
		public void SetWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImageEllipsoidSource.vtkImageEllipsoidSource_SetWholeExtent_37(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001687 RID: 5767
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageEllipsoidSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001688 RID: 5768
		public new static readonly string MRClassNameKey = "class vtkImageEllipsoidSource";
	}
}
