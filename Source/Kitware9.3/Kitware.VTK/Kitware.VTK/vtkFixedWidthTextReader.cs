using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFixedWidthTextReader
	/// </summary>
	/// <remarks>
	///    reader for pulling in text files with fixed-width fields
	///
	///
	///
	/// vtkFixedWidthTextReader reads in a table from a text file where
	/// each column occupies a certain number of characters.
	///
	/// This class emits ProgressEvent for every 100 lines it reads.
	///
	///
	/// @warning
	/// This first version of the reader will assume that all fields have
	/// the same width.  It also assumes that the first line in the file
	/// has at least as many fields (i.e. at least as many characters) as
	/// any other line in the file.
	///
	/// @par Thanks:
	/// Thanks to Andy Wilson from Sandia National Laboratories for
	/// implementing this class.
	/// </remarks>
	// Token: 0x0200019C RID: 412
	public class vtkFixedWidthTextReader : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060050A9 RID: 20649 RVA: 0x00075317 File Offset: 0x00073517
		static vtkFixedWidthTextReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFixedWidthTextReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFixedWidthTextReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060050AA RID: 20650 RVA: 0x0007533F File Offset: 0x0007353F
		public vtkFixedWidthTextReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060050AB RID: 20651
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedWidthTextReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050AC RID: 20652 RVA: 0x00075350 File Offset: 0x00073550
		public new static vtkFixedWidthTextReader New()
		{
			vtkFixedWidthTextReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedWidthTextReader.vtkFixedWidthTextReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedWidthTextReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050AD RID: 20653 RVA: 0x000753A4 File Offset: 0x000735A4
		public vtkFixedWidthTextReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkFixedWidthTextReader.vtkFixedWidthTextReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060050AE RID: 20654 RVA: 0x000753E8 File Offset: 0x000735E8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060050AF RID: 20655
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedWidthTextReader_GetFieldWidth_01(HandleRef pThis);

		/// <summary>
		/// Set/get the field width
		/// </summary>
		// Token: 0x060050B0 RID: 20656 RVA: 0x000753F4 File Offset: 0x000735F4
		public virtual int GetFieldWidth()
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_GetFieldWidth_01(base.GetCppThis());
		}

		// Token: 0x060050B1 RID: 20657
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedWidthTextReader_GetFileName_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050B2 RID: 20658 RVA: 0x00075414 File Offset: 0x00073614
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkFixedWidthTextReader.vtkFixedWidthTextReader_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060050B3 RID: 20659
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFixedWidthTextReader_GetHaveHeaders_03(HandleRef pThis);

		/// <summary>
		/// Set/get whether to treat the first line of the file as headers.
		/// </summary>
		// Token: 0x060050B4 RID: 20660 RVA: 0x00075450 File Offset: 0x00073650
		public virtual bool GetHaveHeaders()
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_GetHaveHeaders_03(base.GetCppThis()) != 0;
		}

		// Token: 0x060050B5 RID: 20661
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedWidthTextReader_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050B6 RID: 20662 RVA: 0x00075478 File Offset: 0x00073678
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x060050B7 RID: 20663
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFixedWidthTextReader_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050B8 RID: 20664 RVA: 0x00075498 File Offset: 0x00073698
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x060050B9 RID: 20665
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFixedWidthTextReader_GetStripWhiteSpace_06(HandleRef pThis);

		/// <summary>
		/// If set, this flag will cause the reader to strip whitespace from
		/// the beginning and ending of each field.  Defaults to off.
		/// </summary>
		// Token: 0x060050BA RID: 20666 RVA: 0x000754B4 File Offset: 0x000736B4
		public virtual bool GetStripWhiteSpace()
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_GetStripWhiteSpace_06(base.GetCppThis()) != 0;
		}

		// Token: 0x060050BB RID: 20667
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedWidthTextReader_GetTableErrorObserver_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set/get the ErrorObserver for the internal vtkTable
		/// This is useful for applications that want to catch error messages.
		/// </summary>
		// Token: 0x060050BC RID: 20668 RVA: 0x000754DC File Offset: 0x000736DC
		public virtual vtkCommand GetTableErrorObserver()
		{
			vtkCommand vtkCommand = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedWidthTextReader.vtkFixedWidthTextReader_GetTableErrorObserver_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCommand = (vtkCommand)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCommand.Register(null);
				}
			}
			return vtkCommand;
		}

		// Token: 0x060050BD RID: 20669
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedWidthTextReader_HaveHeadersOff_08(HandleRef pThis);

		/// <summary>
		/// Set/get whether to treat the first line of the file as headers.
		/// </summary>
		// Token: 0x060050BE RID: 20670 RVA: 0x0007554B File Offset: 0x0007374B
		public virtual void HaveHeadersOff()
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_HaveHeadersOff_08(base.GetCppThis());
		}

		// Token: 0x060050BF RID: 20671
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedWidthTextReader_HaveHeadersOn_09(HandleRef pThis);

		/// <summary>
		/// Set/get whether to treat the first line of the file as headers.
		/// </summary>
		// Token: 0x060050C0 RID: 20672 RVA: 0x0007555A File Offset: 0x0007375A
		public virtual void HaveHeadersOn()
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_HaveHeadersOn_09(base.GetCppThis());
		}

		// Token: 0x060050C1 RID: 20673
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedWidthTextReader_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050C2 RID: 20674 RVA: 0x0007556C File Offset: 0x0007376C
		public override int IsA(string type)
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x060050C3 RID: 20675
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFixedWidthTextReader_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050C4 RID: 20676 RVA: 0x0007558C File Offset: 0x0007378C
		public new static int IsTypeOf(string type)
		{
			return vtkFixedWidthTextReader.vtkFixedWidthTextReader_IsTypeOf_11(type);
		}

		// Token: 0x060050C5 RID: 20677
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedWidthTextReader_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050C6 RID: 20678 RVA: 0x000755A8 File Offset: 0x000737A8
		public new vtkFixedWidthTextReader NewInstance()
		{
			vtkFixedWidthTextReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedWidthTextReader.vtkFixedWidthTextReader_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFixedWidthTextReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060050C7 RID: 20679
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFixedWidthTextReader_SafeDownCast_14(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050C8 RID: 20680 RVA: 0x00075604 File Offset: 0x00073804
		public new static vtkFixedWidthTextReader SafeDownCast(vtkObjectBase o)
		{
			vtkFixedWidthTextReader vtkFixedWidthTextReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFixedWidthTextReader.vtkFixedWidthTextReader_SafeDownCast_14((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFixedWidthTextReader = (vtkFixedWidthTextReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFixedWidthTextReader.Register(null);
				}
			}
			return vtkFixedWidthTextReader;
		}

		// Token: 0x060050C9 RID: 20681
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedWidthTextReader_SetFieldWidth_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the field width
		/// </summary>
		// Token: 0x060050CA RID: 20682 RVA: 0x00075683 File Offset: 0x00073883
		public virtual void SetFieldWidth(int _arg)
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_SetFieldWidth_15(base.GetCppThis(), _arg);
		}

		// Token: 0x060050CB RID: 20683
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedWidthTextReader_SetFileName_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060050CC RID: 20684 RVA: 0x00075693 File Offset: 0x00073893
		public virtual void SetFileName(string _arg)
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_SetFileName_16(base.GetCppThis(), _arg);
		}

		// Token: 0x060050CD RID: 20685
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedWidthTextReader_SetHaveHeaders_17(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/get whether to treat the first line of the file as headers.
		/// </summary>
		// Token: 0x060050CE RID: 20686 RVA: 0x000756A3 File Offset: 0x000738A3
		public virtual void SetHaveHeaders(bool _arg)
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_SetHaveHeaders_17(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060050CF RID: 20687
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedWidthTextReader_SetStripWhiteSpace_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// If set, this flag will cause the reader to strip whitespace from
		/// the beginning and ending of each field.  Defaults to off.
		/// </summary>
		// Token: 0x060050D0 RID: 20688 RVA: 0x000756BB File Offset: 0x000738BB
		public virtual void SetStripWhiteSpace(bool _arg)
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_SetStripWhiteSpace_18(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x060050D1 RID: 20689
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedWidthTextReader_SetTableErrorObserver_19(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set/get the ErrorObserver for the internal vtkTable
		/// This is useful for applications that want to catch error messages.
		/// </summary>
		// Token: 0x060050D2 RID: 20690 RVA: 0x000756D4 File Offset: 0x000738D4
		public void SetTableErrorObserver(vtkCommand arg0)
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_SetTableErrorObserver_19(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x060050D3 RID: 20691
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedWidthTextReader_StripWhiteSpaceOff_20(HandleRef pThis);

		/// <summary>
		/// If set, this flag will cause the reader to strip whitespace from
		/// the beginning and ending of each field.  Defaults to off.
		/// </summary>
		// Token: 0x060050D4 RID: 20692 RVA: 0x00075703 File Offset: 0x00073903
		public virtual void StripWhiteSpaceOff()
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_StripWhiteSpaceOff_20(base.GetCppThis());
		}

		// Token: 0x060050D5 RID: 20693
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFixedWidthTextReader_StripWhiteSpaceOn_21(HandleRef pThis);

		/// <summary>
		/// If set, this flag will cause the reader to strip whitespace from
		/// the beginning and ending of each field.  Defaults to off.
		/// </summary>
		// Token: 0x060050D6 RID: 20694 RVA: 0x00075712 File Offset: 0x00073912
		public virtual void StripWhiteSpaceOn()
		{
			vtkFixedWidthTextReader.vtkFixedWidthTextReader_StripWhiteSpaceOn_21(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400079B RID: 1947
		public new const string MRFullTypeName = "Kitware.VTK.vtkFixedWidthTextReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400079C RID: 1948
		public new static readonly string MRClassNameKey = "class vtkFixedWidthTextReader";
	}
}
