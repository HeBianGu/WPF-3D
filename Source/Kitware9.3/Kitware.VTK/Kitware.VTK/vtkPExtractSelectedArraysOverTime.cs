using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPExtractSelectedArraysOverTime
	/// </summary>
	/// <remarks>
	///    extracts a selection over time.
	///
	/// vtkPExtractSelectedArraysOverTime is a parallelized version of
	/// vtkExtractSelectedArraysOverTime. It simply changes the types of internal
	/// filters used to their parallelized versions. Thus instead of using
	/// vtkExtractDataArraysOverTime over time, it's changed to
	/// vtkPExtractDataArraysOverTime.
	///
	/// </remarks>
	/// <seealso>
	///  vtkExtractDataArraysOverTime, vtkPExtractDataArraysOverTime
	/// </seealso>
	// Token: 0x02000514 RID: 1300
	public class vtkPExtractSelectedArraysOverTime : vtkExtractSelectedArraysOverTime
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E886 RID: 59526 RVA: 0x0014430B File Offset: 0x0014250B
		static vtkPExtractSelectedArraysOverTime()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPExtractSelectedArraysOverTime.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPExtractSelectedArraysOverTime"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E887 RID: 59527 RVA: 0x00144333 File Offset: 0x00142533
		public vtkPExtractSelectedArraysOverTime(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E888 RID: 59528
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractSelectedArraysOverTime_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E889 RID: 59529 RVA: 0x00144344 File Offset: 0x00142544
		public new static vtkPExtractSelectedArraysOverTime New()
		{
			vtkPExtractSelectedArraysOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractSelectedArraysOverTime.vtkPExtractSelectedArraysOverTime_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExtractSelectedArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E88A RID: 59530 RVA: 0x00144398 File Offset: 0x00142598
		public vtkPExtractSelectedArraysOverTime() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPExtractSelectedArraysOverTime.vtkPExtractSelectedArraysOverTime_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E88B RID: 59531 RVA: 0x001443DC File Offset: 0x001425DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E88C RID: 59532
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractSelectedArraysOverTime_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600E88D RID: 59533 RVA: 0x001443E8 File Offset: 0x001425E8
		public vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractSelectedArraysOverTime.vtkPExtractSelectedArraysOverTime_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E88E RID: 59534
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E88F RID: 59535 RVA: 0x00144458 File Offset: 0x00142658
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPExtractSelectedArraysOverTime.vtkPExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E890 RID: 59536
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E891 RID: 59537 RVA: 0x00144478 File Offset: 0x00142678
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPExtractSelectedArraysOverTime.vtkPExtractSelectedArraysOverTime_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E892 RID: 59538
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPExtractSelectedArraysOverTime_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E893 RID: 59539 RVA: 0x00144494 File Offset: 0x00142694
		public override int IsA(string type)
		{
			return vtkPExtractSelectedArraysOverTime.vtkPExtractSelectedArraysOverTime_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E894 RID: 59540
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPExtractSelectedArraysOverTime_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E895 RID: 59541 RVA: 0x001444B4 File Offset: 0x001426B4
		public new static int IsTypeOf(string type)
		{
			return vtkPExtractSelectedArraysOverTime.vtkPExtractSelectedArraysOverTime_IsTypeOf_05(type);
		}

		// Token: 0x0600E896 RID: 59542
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractSelectedArraysOverTime_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E897 RID: 59543 RVA: 0x001444D0 File Offset: 0x001426D0
		public new vtkPExtractSelectedArraysOverTime NewInstance()
		{
			vtkPExtractSelectedArraysOverTime result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractSelectedArraysOverTime.vtkPExtractSelectedArraysOverTime_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPExtractSelectedArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E898 RID: 59544
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPExtractSelectedArraysOverTime_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E899 RID: 59545 RVA: 0x0014452C File Offset: 0x0014272C
		public new static vtkPExtractSelectedArraysOverTime SafeDownCast(vtkObjectBase o)
		{
			vtkPExtractSelectedArraysOverTime vtkPExtractSelectedArraysOverTime = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPExtractSelectedArraysOverTime.vtkPExtractSelectedArraysOverTime_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPExtractSelectedArraysOverTime = (vtkPExtractSelectedArraysOverTime)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPExtractSelectedArraysOverTime.Register(null);
				}
			}
			return vtkPExtractSelectedArraysOverTime;
		}

		// Token: 0x0600E89A RID: 59546
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPExtractSelectedArraysOverTime_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600E89B RID: 59547 RVA: 0x001445AC File Offset: 0x001427AC
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPExtractSelectedArraysOverTime.vtkPExtractSelectedArraysOverTime_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001112 RID: 4370
		public new const string MRFullTypeName = "Kitware.VTK.vtkPExtractSelectedArraysOverTime";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001113 RID: 4371
		public new static readonly string MRClassNameKey = "class vtkPExtractSelectedArraysOverTime";
	}
}
