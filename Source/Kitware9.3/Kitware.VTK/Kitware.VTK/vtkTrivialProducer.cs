using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTrivialProducer
	/// </summary>
	/// <remarks>
	///    Producer for stand-alone data objects.
	///
	/// vtkTrivialProducer allows stand-alone data objects to be connected
	/// as inputs in a pipeline.  All data objects that are connected to a
	/// pipeline involving vtkAlgorithm must have a producer.  This trivial
	/// producer allows data objects that are hand-constructed in a program
	/// without another vtk producer to be connected.
	/// </remarks>
	// Token: 0x020009E9 RID: 2537
	public class vtkTrivialProducer : vtkAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601A634 RID: 108084 RVA: 0x0024A3C3 File Offset: 0x002485C3
		static vtkTrivialProducer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTrivialProducer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTrivialProducer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601A635 RID: 108085 RVA: 0x0024A3EB File Offset: 0x002485EB
		public vtkTrivialProducer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601A636 RID: 108086
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTrivialProducer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A637 RID: 108087 RVA: 0x0024A3FC File Offset: 0x002485FC
		public new static vtkTrivialProducer New()
		{
			vtkTrivialProducer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTrivialProducer.vtkTrivialProducer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTrivialProducer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A638 RID: 108088 RVA: 0x0024A450 File Offset: 0x00248650
		public vtkTrivialProducer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTrivialProducer.vtkTrivialProducer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601A639 RID: 108089 RVA: 0x0024A494 File Offset: 0x00248694
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601A63A RID: 108090
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTrivialProducer_FillOutputDataInformation_01(HandleRef output, HandleRef outInfo);

		/// <summary>
		/// This method can be used to copy meta-data from an existing data
		/// object to an information object. For example, whole extent,
		/// image data spacing, origin etc.
		/// </summary>
		// Token: 0x0601A63B RID: 108091 RVA: 0x0024A4A0 File Offset: 0x002486A0
		public static void FillOutputDataInformation(vtkDataObject output, vtkInformation outInfo)
		{
			vtkTrivialProducer.vtkTrivialProducer_FillOutputDataInformation_01((output == null) ? default(HandleRef) : output.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		// Token: 0x0601A63C RID: 108092
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTrivialProducer_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// The modified time of this producer is the newer of this object or
		/// the assigned output.
		/// </summary>
		// Token: 0x0601A63D RID: 108093 RVA: 0x0024A4E0 File Offset: 0x002486E0
		public override ulong GetMTime()
		{
			return vtkTrivialProducer.vtkTrivialProducer_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x0601A63E RID: 108094
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTrivialProducer_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A63F RID: 108095 RVA: 0x0024A500 File Offset: 0x00248700
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTrivialProducer.vtkTrivialProducer_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601A640 RID: 108096
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTrivialProducer_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A641 RID: 108097 RVA: 0x0024A520 File Offset: 0x00248720
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTrivialProducer.vtkTrivialProducer_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601A642 RID: 108098
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTrivialProducer_GetWholeExtent_05(HandleRef pThis);

		/// <summary>
		/// Set the whole extent to use for the data this producer is producing.
		/// This may be different than the extent of the output data when
		/// the trivial producer is used in parallel.
		/// </summary>
		// Token: 0x0601A643 RID: 108099 RVA: 0x0024A53C File Offset: 0x0024873C
		public virtual int[] GetWholeExtent()
		{
			IntPtr intPtr = vtkTrivialProducer.vtkTrivialProducer_GetWholeExtent_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601A644 RID: 108100
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTrivialProducer_GetWholeExtent_06(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6);

		/// <summary>
		/// Set the whole extent to use for the data this producer is producing.
		/// This may be different than the extent of the output data when
		/// the trivial producer is used in parallel.
		/// </summary>
		// Token: 0x0601A645 RID: 108101 RVA: 0x0024A584 File Offset: 0x00248784
		public virtual void GetWholeExtent(ref int _arg1, ref int _arg2, ref int _arg3, ref int _arg4, ref int _arg5, ref int _arg6)
		{
			vtkTrivialProducer.vtkTrivialProducer_GetWholeExtent_06(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4, ref _arg5, ref _arg6);
		}

		// Token: 0x0601A646 RID: 108102
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTrivialProducer_GetWholeExtent_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the whole extent to use for the data this producer is producing.
		/// This may be different than the extent of the output data when
		/// the trivial producer is used in parallel.
		/// </summary>
		// Token: 0x0601A647 RID: 108103 RVA: 0x0024A59C File Offset: 0x0024879C
		public virtual void GetWholeExtent(IntPtr _arg)
		{
			vtkTrivialProducer.vtkTrivialProducer_GetWholeExtent_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0601A648 RID: 108104
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTrivialProducer_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A649 RID: 108105 RVA: 0x0024A5AC File Offset: 0x002487AC
		public override int IsA(string type)
		{
			return vtkTrivialProducer.vtkTrivialProducer_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601A64A RID: 108106
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTrivialProducer_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A64B RID: 108107 RVA: 0x0024A5CC File Offset: 0x002487CC
		public new static int IsTypeOf(string type)
		{
			return vtkTrivialProducer.vtkTrivialProducer_IsTypeOf_09(type);
		}

		// Token: 0x0601A64C RID: 108108
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTrivialProducer_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A64D RID: 108109 RVA: 0x0024A5E8 File Offset: 0x002487E8
		public new vtkTrivialProducer NewInstance()
		{
			vtkTrivialProducer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTrivialProducer.vtkTrivialProducer_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTrivialProducer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601A64E RID: 108110
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTrivialProducer_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601A64F RID: 108111 RVA: 0x0024A644 File Offset: 0x00248844
		public new static vtkTrivialProducer SafeDownCast(vtkObjectBase o)
		{
			vtkTrivialProducer vtkTrivialProducer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTrivialProducer.vtkTrivialProducer_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTrivialProducer = (vtkTrivialProducer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTrivialProducer.Register(null);
				}
			}
			return vtkTrivialProducer;
		}

		// Token: 0x0601A650 RID: 108112
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTrivialProducer_SetOutput_13(HandleRef pThis, HandleRef output);

		/// <summary>
		/// Set the data object that is "produced" by this producer.  It is
		/// never really modified.
		/// </summary>
		// Token: 0x0601A651 RID: 108113 RVA: 0x0024A6C4 File Offset: 0x002488C4
		public virtual void SetOutput(vtkDataObject output)
		{
			vtkTrivialProducer.vtkTrivialProducer_SetOutput_13(base.GetCppThis(), (output == null) ? default(HandleRef) : output.GetCppThis());
		}

		// Token: 0x0601A652 RID: 108114
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTrivialProducer_SetWholeExtent_14(HandleRef pThis, int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6);

		/// <summary>
		/// Set the whole extent to use for the data this producer is producing.
		/// This may be different than the extent of the output data when
		/// the trivial producer is used in parallel.
		/// </summary>
		// Token: 0x0601A653 RID: 108115 RVA: 0x0024A6F3 File Offset: 0x002488F3
		public virtual void SetWholeExtent(int _arg1, int _arg2, int _arg3, int _arg4, int _arg5, int _arg6)
		{
			vtkTrivialProducer.vtkTrivialProducer_SetWholeExtent_14(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4, _arg5, _arg6);
		}

		// Token: 0x0601A654 RID: 108116
		[DllImport("Kitware.VTK.CommonExecutionModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTrivialProducer_SetWholeExtent_15(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the whole extent to use for the data this producer is producing.
		/// This may be different than the extent of the output data when
		/// the trivial producer is used in parallel.
		/// </summary>
		// Token: 0x0601A655 RID: 108117 RVA: 0x0024A70B File Offset: 0x0024890B
		public virtual void SetWholeExtent(IntPtr _arg)
		{
			vtkTrivialProducer.vtkTrivialProducer_SetWholeExtent_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CA2 RID: 7330
		public new const string MRFullTypeName = "Kitware.VTK.vtkTrivialProducer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001CA3 RID: 7331
		public new static readonly string MRClassNameKey = "class vtkTrivialProducer";
	}
}
