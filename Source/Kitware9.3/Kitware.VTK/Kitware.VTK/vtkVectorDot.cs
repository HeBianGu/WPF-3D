using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVectorDot
	/// </summary>
	/// <remarks>
	///    generate scalars from dot product of vectors and normals (e.g., show displacement plot)
	///
	/// vtkVectorDot is a filter to generate point scalar values from a dataset.
	/// The scalar value at a point is created by computing the dot product
	/// between the normal and vector at each point. Combined with the appropriate
	/// color map, this can show nodal lines/mode shapes of vibration, or a
	/// displacement plot.
	///
	/// Note that by default the resulting scalars are mapped into a specified
	/// range. This requires an extra pass in the algorithm. This mapping pass can
	/// be disabled (set MapScalars to off).
	///
	/// @warning
	/// This class has been threaded with vtkSMPTools. Using TBB or other
	/// non-sequential type (set in the CMake variable
	/// VTK_SMP_IMPLEMENTATION_TYPE) may improve performance significantly.
	/// </remarks>
	// Token: 0x020009BF RID: 2495
	public class vtkVectorDot : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A109 RID: 106761 RVA: 0x0024219F File Offset: 0x0024039F
		static vtkVectorDot()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVectorDot.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVectorDot"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A10A RID: 106762 RVA: 0x002421C7 File Offset: 0x002403C7
		public vtkVectorDot(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A10B RID: 106763
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorDot_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct object with scalar range (-1,1).
		/// </summary>
		// Token: 0x0601A10C RID: 106764 RVA: 0x002421D8 File Offset: 0x002403D8
		public new static vtkVectorDot New()
		{
			vtkVectorDot result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorDot.vtkVectorDot_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorDot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct object with scalar range (-1,1).
		/// </summary>
		// Token: 0x0601A10D RID: 106765 RVA: 0x0024222C File Offset: 0x0024042C
		public vtkVectorDot() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVectorDot.vtkVectorDot_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A10E RID: 106766 RVA: 0x00242270 File Offset: 0x00240470
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A10F RID: 106767
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorDot_GetActualRange_01(HandleRef pThis);

		/// <summary>
		/// Return the actual range of the generated scalars (prior to mapping).
		/// Note that the data is valid only after the filter executes.
		/// </summary>
		// Token: 0x0601A110 RID: 106768 RVA: 0x0024227C File Offset: 0x0024047C
		public virtual double[] GetActualRange()
		{
			IntPtr intPtr = vtkVectorDot.vtkVectorDot_GetActualRange_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601A111 RID: 106769
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorDot_GetActualRange_02(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Return the actual range of the generated scalars (prior to mapping).
		/// Note that the data is valid only after the filter executes.
		/// </summary>
		// Token: 0x0601A112 RID: 106770 RVA: 0x002422C4 File Offset: 0x002404C4
		public virtual void GetActualRange(IntPtr data)
		{
			vtkVectorDot.vtkVectorDot_GetActualRange_02(base.GetCppThis(), data);
		}

		// Token: 0x0601A113 RID: 106771
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorDot_GetMapScalars_03(HandleRef pThis);

		/// <summary>
		/// Enable/disable the mapping of scalars into a specified range. This will
		/// significantly improve the performance of the algorithm but the resulting
		/// scalar values will strictly be a function of the vector and normal
		/// data. By default, MapScalars is enabled, and the output scalar
		/// values will fall into the range ScalarRange.
		/// </summary>
		// Token: 0x0601A114 RID: 106772 RVA: 0x002422D4 File Offset: 0x002404D4
		public virtual int GetMapScalars()
		{
			return vtkVectorDot.vtkVectorDot_GetMapScalars_03(base.GetCppThis());
		}

		// Token: 0x0601A115 RID: 106773
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVectorDot_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A116 RID: 106774 RVA: 0x002422F4 File Offset: 0x002404F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVectorDot.vtkVectorDot_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601A117 RID: 106775
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVectorDot_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A118 RID: 106776 RVA: 0x00242314 File Offset: 0x00240514
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVectorDot.vtkVectorDot_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601A119 RID: 106777
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorDot_GetScalarRange_06(HandleRef pThis);

		/// <summary>
		/// Specify the range into which to map the scalars. This mapping only
		/// occurs if MapScalars is enabled.
		/// </summary>
		// Token: 0x0601A11A RID: 106778 RVA: 0x00242330 File Offset: 0x00240530
		public virtual double[] GetScalarRange()
		{
			IntPtr intPtr = vtkVectorDot.vtkVectorDot_GetScalarRange_06(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601A11B RID: 106779
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorDot_GetScalarRange_07(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Specify the range into which to map the scalars. This mapping only
		/// occurs if MapScalars is enabled.
		/// </summary>
		// Token: 0x0601A11C RID: 106780 RVA: 0x00242378 File Offset: 0x00240578
		public virtual void GetScalarRange(IntPtr data)
		{
			vtkVectorDot.vtkVectorDot_GetScalarRange_07(base.GetCppThis(), data);
		}

		// Token: 0x0601A11D RID: 106781
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorDot_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A11E RID: 106782 RVA: 0x00242388 File Offset: 0x00240588
		public override int IsA(string type)
		{
			return vtkVectorDot.vtkVectorDot_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601A11F RID: 106783
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVectorDot_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A120 RID: 106784 RVA: 0x002423A8 File Offset: 0x002405A8
		public new static int IsTypeOf(string type)
		{
			return vtkVectorDot.vtkVectorDot_IsTypeOf_09(type);
		}

		// Token: 0x0601A121 RID: 106785
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorDot_MapScalarsOff_10(HandleRef pThis);

		/// <summary>
		/// Enable/disable the mapping of scalars into a specified range. This will
		/// significantly improve the performance of the algorithm but the resulting
		/// scalar values will strictly be a function of the vector and normal
		/// data. By default, MapScalars is enabled, and the output scalar
		/// values will fall into the range ScalarRange.
		/// </summary>
		// Token: 0x0601A122 RID: 106786 RVA: 0x002423C2 File Offset: 0x002405C2
		public virtual void MapScalarsOff()
		{
			vtkVectorDot.vtkVectorDot_MapScalarsOff_10(base.GetCppThis());
		}

		// Token: 0x0601A123 RID: 106787
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorDot_MapScalarsOn_11(HandleRef pThis);

		/// <summary>
		/// Enable/disable the mapping of scalars into a specified range. This will
		/// significantly improve the performance of the algorithm but the resulting
		/// scalar values will strictly be a function of the vector and normal
		/// data. By default, MapScalars is enabled, and the output scalar
		/// values will fall into the range ScalarRange.
		/// </summary>
		// Token: 0x0601A124 RID: 106788 RVA: 0x002423D1 File Offset: 0x002405D1
		public virtual void MapScalarsOn()
		{
			vtkVectorDot.vtkVectorDot_MapScalarsOn_11(base.GetCppThis());
		}

		// Token: 0x0601A125 RID: 106789
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorDot_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A126 RID: 106790 RVA: 0x002423E0 File Offset: 0x002405E0
		public new vtkVectorDot NewInstance()
		{
			vtkVectorDot result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorDot.vtkVectorDot_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVectorDot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A127 RID: 106791
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVectorDot_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A128 RID: 106792 RVA: 0x0024243C File Offset: 0x0024063C
		public new static vtkVectorDot SafeDownCast(vtkObjectBase o)
		{
			vtkVectorDot vtkVectorDot = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVectorDot.vtkVectorDot_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVectorDot = (vtkVectorDot)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVectorDot.Register(null);
				}
			}
			return vtkVectorDot;
		}

		// Token: 0x0601A129 RID: 106793
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorDot_SetMapScalars_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Enable/disable the mapping of scalars into a specified range. This will
		/// significantly improve the performance of the algorithm but the resulting
		/// scalar values will strictly be a function of the vector and normal
		/// data. By default, MapScalars is enabled, and the output scalar
		/// values will fall into the range ScalarRange.
		/// </summary>
		// Token: 0x0601A12A RID: 106794 RVA: 0x002424BB File Offset: 0x002406BB
		public virtual void SetMapScalars(int _arg)
		{
			vtkVectorDot.vtkVectorDot_SetMapScalars_15(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A12B RID: 106795
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorDot_SetScalarRange_16(HandleRef pThis, double _arg1, double _arg2);

		/// <summary>
		/// Specify the range into which to map the scalars. This mapping only
		/// occurs if MapScalars is enabled.
		/// </summary>
		// Token: 0x0601A12C RID: 106796 RVA: 0x002424CB File Offset: 0x002406CB
		public virtual void SetScalarRange(double _arg1, double _arg2)
		{
			vtkVectorDot.vtkVectorDot_SetScalarRange_16(base.GetCppThis(), _arg1, _arg2);
		}

		// Token: 0x0601A12D RID: 106797
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVectorDot_SetScalarRange_17(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Specify the range into which to map the scalars. This mapping only
		/// occurs if MapScalars is enabled.
		/// </summary>
		// Token: 0x0601A12E RID: 106798 RVA: 0x002424DC File Offset: 0x002406DC
		public void SetScalarRange(IntPtr _arg)
		{
			vtkVectorDot.vtkVectorDot_SetScalarRange_17(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C47 RID: 7239
		public new const string MRFullTypeName = "Kitware.VTK.vtkVectorDot";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C48 RID: 7240
		public new static readonly string MRClassNameKey = "class vtkVectorDot";
	}
}
