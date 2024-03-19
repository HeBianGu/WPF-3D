using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkExtractDataOverTime
	/// </summary>
	/// <remarks>
	///    extract point data from a time sequence for
	/// a specified point id.
	///
	/// This filter extracts the point data from a time sequence and specified index
	/// and creates an output of the same type as the input but with Points
	/// containing "number of time steps" points; the point and PointData
	/// corresponding to the PointIndex are extracted at each time step and added to
	/// the output.  A PointData array is added called "Time" (or "TimeData" if
	/// there is already an array called "Time"), which is the time at each index.
	/// </remarks>
	// Token: 0x020006A9 RID: 1705
	public class vtkExtractDataOverTime : vtkPointSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060123D0 RID: 74704 RVA: 0x00198CF3 File Offset: 0x00196EF3
		static vtkExtractDataOverTime()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkExtractDataOverTime.MRClassNameKey, Type.GetType("Kitware.VTK.vtkExtractDataOverTime"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060123D1 RID: 74705 RVA: 0x00198D1B File Offset: 0x00196F1B
		public vtkExtractDataOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060123D2 RID: 74706
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractDataOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123D3 RID: 74707 RVA: 0x00198D2C File Offset: 0x00196F2C
		public new static vtkExtractDataOverTime New()
		{
			vtkExtractDataOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractDataOverTime.vtkExtractDataOverTime_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractDataOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123D4 RID: 74708 RVA: 0x00198D80 File Offset: 0x00196F80
		public vtkExtractDataOverTime() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkExtractDataOverTime.vtkExtractDataOverTime_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060123D5 RID: 74709 RVA: 0x00198DC4 File Offset: 0x00196FC4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060123D6 RID: 74710
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractDataOverTime_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123D7 RID: 74711 RVA: 0x00198DD0 File Offset: 0x00196FD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkExtractDataOverTime.vtkExtractDataOverTime_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060123D8 RID: 74712
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkExtractDataOverTime_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123D9 RID: 74713 RVA: 0x00198DF0 File Offset: 0x00196FF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkExtractDataOverTime.vtkExtractDataOverTime_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060123DA RID: 74714
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataOverTime_GetNumberOfTimeSteps_03(HandleRef pThis);

		/// <summary>
		/// Get the number of time steps
		/// </summary>
		// Token: 0x060123DB RID: 74715 RVA: 0x00198E0C File Offset: 0x0019700C
		public virtual int GetNumberOfTimeSteps()
		{
			return vtkExtractDataOverTime.vtkExtractDataOverTime_GetNumberOfTimeSteps_03(base.GetCppThis());
		}

		// Token: 0x060123DC RID: 74716
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataOverTime_GetPointIndex_04(HandleRef pThis);

		/// <summary>
		/// Index of point to extract at each time step
		/// </summary>
		// Token: 0x060123DD RID: 74717 RVA: 0x00198E2C File Offset: 0x0019702C
		public virtual int GetPointIndex()
		{
			return vtkExtractDataOverTime.vtkExtractDataOverTime_GetPointIndex_04(base.GetCppThis());
		}

		// Token: 0x060123DE RID: 74718
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataOverTime_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123DF RID: 74719 RVA: 0x00198E4C File Offset: 0x0019704C
		public override int IsA(string type)
		{
			return vtkExtractDataOverTime.vtkExtractDataOverTime_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060123E0 RID: 74720
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkExtractDataOverTime_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123E1 RID: 74721 RVA: 0x00198E6C File Offset: 0x0019706C
		public new static int IsTypeOf(string type)
		{
			return vtkExtractDataOverTime.vtkExtractDataOverTime_IsTypeOf_06(type);
		}

		// Token: 0x060123E2 RID: 74722
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractDataOverTime_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123E3 RID: 74723 RVA: 0x00198E88 File Offset: 0x00197088
		public new vtkExtractDataOverTime NewInstance()
		{
			vtkExtractDataOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractDataOverTime.vtkExtractDataOverTime_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkExtractDataOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060123E4 RID: 74724
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkExtractDataOverTime_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060123E5 RID: 74725 RVA: 0x00198EE4 File Offset: 0x001970E4
		public new static vtkExtractDataOverTime SafeDownCast(vtkObjectBase o)
		{
			vtkExtractDataOverTime vtkExtractDataOverTime = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkExtractDataOverTime.vtkExtractDataOverTime_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtractDataOverTime = (vtkExtractDataOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtractDataOverTime.Register(null);
				}
			}
			return vtkExtractDataOverTime;
		}

		// Token: 0x060123E6 RID: 74726
		[DllImport("Kitware.VTK.FiltersExtraction.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkExtractDataOverTime_SetPointIndex_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Index of point to extract at each time step
		/// </summary>
		// Token: 0x060123E7 RID: 74727 RVA: 0x00198F63 File Offset: 0x00197163
		public virtual void SetPointIndex(int _arg)
		{
			vtkExtractDataOverTime.vtkExtractDataOverTime_SetPointIndex_10(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001500 RID: 5376
		public new const string MRFullTypeName = "Kitware.VTK.vtkExtractDataOverTime";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001501 RID: 5377
		public new static readonly string MRClassNameKey = "class vtkExtractDataOverTime";
	}
}
