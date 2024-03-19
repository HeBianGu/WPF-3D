using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCPExodusIIInSituReader
	/// </summary>
	/// <remarks>
	///    Read an Exodus II file into data structures
	/// that map the raw arrays returned by the Exodus II library into a multi-block
	/// data set containing vtkUnstructuredGridBase subclasses.
	///
	///
	/// This class can be used to import Exodus II files into VTK without repacking
	/// the data into the standard VTK memory layout, avoiding the cost of a deep
	/// copy.
	/// </remarks>
	// Token: 0x020001B6 RID: 438
	public class vtkCPExodusIIInSituReader : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600542A RID: 21546 RVA: 0x0007A92B File Offset: 0x00078B2B
		static vtkCPExodusIIInSituReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCPExodusIIInSituReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCPExodusIIInSituReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600542B RID: 21547 RVA: 0x0007A953 File Offset: 0x00078B53
		public vtkCPExodusIIInSituReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600542C RID: 21548
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCPExodusIIInSituReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600542D RID: 21549 RVA: 0x0007A964 File Offset: 0x00078B64
		public new static vtkCPExodusIIInSituReader New()
		{
			vtkCPExodusIIInSituReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCPExodusIIInSituReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600542E RID: 21550 RVA: 0x0007A9B8 File Offset: 0x00078BB8
		public vtkCPExodusIIInSituReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600542F RID: 21551 RVA: 0x0007A9FC File Offset: 0x00078BFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005430 RID: 21552
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCPExodusIIInSituReader_GetCurrentTimeStep_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the current timestep to read as a zero-based index.
		/// </summary>
		// Token: 0x06005431 RID: 21553 RVA: 0x0007AA08 File Offset: 0x00078C08
		public virtual int GetCurrentTimeStep()
		{
			return vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_GetCurrentTimeStep_01(base.GetCppThis());
		}

		// Token: 0x06005432 RID: 21554
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCPExodusIIInSituReader_GetFileName_02(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the Exodus file to read.
		/// </summary>
		// Token: 0x06005433 RID: 21555 RVA: 0x0007AA28 File Offset: 0x00078C28
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005434 RID: 21556
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCPExodusIIInSituReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005435 RID: 21557 RVA: 0x0007AA64 File Offset: 0x00078C64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06005436 RID: 21558
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCPExodusIIInSituReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005437 RID: 21559 RVA: 0x0007AA84 File Offset: 0x00078C84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06005438 RID: 21560
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCPExodusIIInSituReader_GetTimeStepRange_05(HandleRef pThis);

		/// <summary>
		/// Get the range of timesteps, represented as [0, numTimeSteps - 1]. Call
		/// UpdateInformation first to set this without reading any timestep data.
		/// </summary>
		// Token: 0x06005439 RID: 21561 RVA: 0x0007AAA0 File Offset: 0x00078CA0
		public virtual int[] GetTimeStepRange()
		{
			IntPtr intPtr = vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_GetTimeStepRange_05(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[2];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600543A RID: 21562
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCPExodusIIInSituReader_GetTimeStepRange_06(HandleRef pThis, ref int _arg1, ref int _arg2);

		/// <summary>
		/// Get the range of timesteps, represented as [0, numTimeSteps - 1]. Call
		/// UpdateInformation first to set this without reading any timestep data.
		/// </summary>
		// Token: 0x0600543B RID: 21563 RVA: 0x0007AAE8 File Offset: 0x00078CE8
		public virtual void GetTimeStepRange(ref int _arg1, ref int _arg2)
		{
			vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_GetTimeStepRange_06(base.GetCppThis(), ref _arg1, ref _arg2);
		}

		// Token: 0x0600543C RID: 21564
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCPExodusIIInSituReader_GetTimeStepRange_07(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Get the range of timesteps, represented as [0, numTimeSteps - 1]. Call
		/// UpdateInformation first to set this without reading any timestep data.
		/// </summary>
		// Token: 0x0600543D RID: 21565 RVA: 0x0007AAF9 File Offset: 0x00078CF9
		public virtual void GetTimeStepRange(IntPtr _arg)
		{
			vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_GetTimeStepRange_07(base.GetCppThis(), _arg);
		}

		// Token: 0x0600543E RID: 21566
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCPExodusIIInSituReader_GetTimeStepValue_08(HandleRef pThis, int step);

		/// <summary>
		/// Get the floating point tag associated with the timestep at 'step'.
		/// </summary>
		// Token: 0x0600543F RID: 21567 RVA: 0x0007AB0C File Offset: 0x00078D0C
		public double GetTimeStepValue(int step)
		{
			return vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_GetTimeStepValue_08(base.GetCppThis(), step);
		}

		// Token: 0x06005440 RID: 21568
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCPExodusIIInSituReader_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005441 RID: 21569 RVA: 0x0007AB2C File Offset: 0x00078D2C
		public override int IsA(string type)
		{
			return vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06005442 RID: 21570
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCPExodusIIInSituReader_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005443 RID: 21571 RVA: 0x0007AB4C File Offset: 0x00078D4C
		public new static int IsTypeOf(string type)
		{
			return vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_IsTypeOf_10(type);
		}

		// Token: 0x06005444 RID: 21572
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCPExodusIIInSituReader_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005445 RID: 21573 RVA: 0x0007AB68 File Offset: 0x00078D68
		public new vtkCPExodusIIInSituReader NewInstance()
		{
			vtkCPExodusIIInSituReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCPExodusIIInSituReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005446 RID: 21574
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCPExodusIIInSituReader_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005447 RID: 21575 RVA: 0x0007ABC4 File Offset: 0x00078DC4
		public new static vtkCPExodusIIInSituReader SafeDownCast(vtkObjectBase o)
		{
			vtkCPExodusIIInSituReader vtkCPExodusIIInSituReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCPExodusIIInSituReader = (vtkCPExodusIIInSituReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCPExodusIIInSituReader.Register(null);
				}
			}
			return vtkCPExodusIIInSituReader;
		}

		// Token: 0x06005448 RID: 21576
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCPExodusIIInSituReader_SetCurrentTimeStep_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the current timestep to read as a zero-based index.
		/// </summary>
		// Token: 0x06005449 RID: 21577 RVA: 0x0007AC43 File Offset: 0x00078E43
		public virtual void SetCurrentTimeStep(int _arg)
		{
			vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_SetCurrentTimeStep_14(base.GetCppThis(), _arg);
		}

		// Token: 0x0600544A RID: 21578
		[DllImport("Kitware.VTK.IOExodus.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCPExodusIIInSituReader_SetFileName_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the Exodus file to read.
		/// </summary>
		// Token: 0x0600544B RID: 21579 RVA: 0x0007AC53 File Offset: 0x00078E53
		public virtual void SetFileName(string _arg)
		{
			vtkCPExodusIIInSituReader.vtkCPExodusIIInSituReader_SetFileName_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007D9 RID: 2009
		public new const string MRFullTypeName = "Kitware.VTK.vtkCPExodusIIInSituReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007DA RID: 2010
		public new static readonly string MRClassNameKey = "class vtkCPExodusIIInSituReader";
	}
}
