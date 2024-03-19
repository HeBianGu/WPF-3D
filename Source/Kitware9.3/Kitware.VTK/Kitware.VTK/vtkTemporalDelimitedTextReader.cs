using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTemporalDelimitedTextReader
	/// </summary>
	/// <remarks>
	///    reads a delimited ascii or unicode text files and and output a
	/// temporal vtkTable.
	///
	/// This reader requires that FieldDelimiterCharacters is set before
	/// the pipeline is executed, otherwise it will produce an empty output.
	///
	/// A column can be selected as time step indicator using the SetTimeColumnName
	/// or SetTimeColumnId functions. If so, for a given time step 's' only the
	/// lines where the time step indicator column have the value 's' are present.
	/// To control if the time step indicator column should be present in the
	/// output, a RemoveTimeStepColumn option is available. If no time step
	/// indicator column is given by the user, the whole file it outputted.
	///
	/// This reader assume the time step column is numeric. A warning is
	/// set otherwise. The DetectNumericColumns field is set to on,
	/// do not change this field unless you really know what you are
	/// doing.
	///
	/// @see vtkDelimitedTextReader
	/// </remarks>
	// Token: 0x020001A6 RID: 422
	public class vtkTemporalDelimitedTextReader : vtkDelimitedTextReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005206 RID: 20998 RVA: 0x00077867 File Offset: 0x00075A67
		static vtkTemporalDelimitedTextReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTemporalDelimitedTextReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTemporalDelimitedTextReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005207 RID: 20999 RVA: 0x0007788F File Offset: 0x00075A8F
		public vtkTemporalDelimitedTextReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005208 RID: 21000
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalDelimitedTextReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005209 RID: 21001 RVA: 0x000778A0 File Offset: 0x00075AA0
		public new static vtkTemporalDelimitedTextReader New()
		{
			vtkTemporalDelimitedTextReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600520A RID: 21002 RVA: 0x000778F4 File Offset: 0x00075AF4
		public vtkTemporalDelimitedTextReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600520B RID: 21003 RVA: 0x00077938 File Offset: 0x00075B38
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600520C RID: 21004
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkTemporalDelimitedTextReader_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// This mechanism ensures the actual data is only re-read when necessary.
		/// Here, we ensure the GetMTime of this reader stay consistent by returning
		/// the latest between the MTime of this reader and the internal one.
		///
		/// @see InternalModified
		/// </summary>
		// Token: 0x0600520D RID: 21005 RVA: 0x00077944 File Offset: 0x00075B44
		public override ulong GetMTime()
		{
			return vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x0600520E RID: 21006
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalDelimitedTextReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600520F RID: 21007 RVA: 0x00077964 File Offset: 0x00075B64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005210 RID: 21008
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTemporalDelimitedTextReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005211 RID: 21009 RVA: 0x00077984 File Offset: 0x00075B84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005212 RID: 21010
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkTemporalDelimitedTextReader_GetRemoveTimeStepColumn_04(HandleRef pThis);

		/// <summary>
		/// Set the RemoveTimeStepColumn flag
		/// If this boolean is true, the output will not contain the Time step column.
		/// Default to true.
		/// </summary>
		// Token: 0x06005213 RID: 21011 RVA: 0x000779A0 File Offset: 0x00075BA0
		public virtual bool GetRemoveTimeStepColumn()
		{
			return vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_GetRemoveTimeStepColumn_04(base.GetCppThis()) != 0;
		}

		// Token: 0x06005214 RID: 21012
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalDelimitedTextReader_GetTimeColumnId_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the column to use as time indicator.
		/// It the TimeColumnId is equal to -1, the TimeColumnName will be used
		/// instead.
		/// If no column has been chosen using either the TimeColumnId or the
		/// TimeColumnName the whole input file is outputted.
		/// Default to -1.
		/// </summary>
		// Token: 0x06005215 RID: 21013 RVA: 0x000779C8 File Offset: 0x00075BC8
		public virtual int GetTimeColumnId()
		{
			return vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_GetTimeColumnId_05(base.GetCppThis());
		}

		// Token: 0x06005216 RID: 21014
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkTemporalDelimitedTextReader_GetTimeColumnName_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the column to use as time indicator.
		/// Ignored if TimeColumnId is not equal to -1.
		/// If no column has been chosen using either the TimeColumnId or the
		/// TimeColumnName the whole input file is outputted.
		/// Default to empty string.
		/// </summary>
		// Token: 0x06005217 RID: 21015 RVA: 0x000779E8 File Offset: 0x00075BE8
		public virtual string GetTimeColumnName()
		{
			return vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_GetTimeColumnName_06(base.GetCppThis());
		}

		// Token: 0x06005218 RID: 21016
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalDelimitedTextReader_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005219 RID: 21017 RVA: 0x00077A08 File Offset: 0x00075C08
		public override int IsA(string type)
		{
			return vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0600521A RID: 21018
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTemporalDelimitedTextReader_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600521B RID: 21019 RVA: 0x00077A28 File Offset: 0x00075C28
		public new static int IsTypeOf(string type)
		{
			return vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_IsTypeOf_08(type);
		}

		// Token: 0x0600521C RID: 21020
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalDelimitedTextReader_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600521D RID: 21021 RVA: 0x00077A44 File Offset: 0x00075C44
		public new vtkTemporalDelimitedTextReader NewInstance()
		{
			vtkTemporalDelimitedTextReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTemporalDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600521E RID: 21022
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTemporalDelimitedTextReader_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600521F RID: 21023 RVA: 0x00077AA0 File Offset: 0x00075CA0
		public new static vtkTemporalDelimitedTextReader SafeDownCast(vtkObjectBase o)
		{
			vtkTemporalDelimitedTextReader vtkTemporalDelimitedTextReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTemporalDelimitedTextReader = (vtkTemporalDelimitedTextReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTemporalDelimitedTextReader.Register(null);
				}
			}
			return vtkTemporalDelimitedTextReader;
		}

		// Token: 0x06005220 RID: 21024
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalDelimitedTextReader_SetRemoveTimeStepColumn_12(HandleRef pThis, byte rts);

		/// <summary>
		/// Set the RemoveTimeStepColumn flag
		/// If this boolean is true, the output will not contain the Time step column.
		/// Default to true.
		/// </summary>
		// Token: 0x06005221 RID: 21025 RVA: 0x00077B1F File Offset: 0x00075D1F
		public void SetRemoveTimeStepColumn(bool rts)
		{
			vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_SetRemoveTimeStepColumn_12(base.GetCppThis(), rts ? (byte)1 : (byte)0);
		}

		// Token: 0x06005222 RID: 21026
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalDelimitedTextReader_SetTimeColumnId_13(HandleRef pThis, int idx);

		/// <summary>
		/// Get/Set the column to use as time indicator.
		/// It the TimeColumnId is equal to -1, the TimeColumnName will be used
		/// instead.
		/// If no column has been chosen using either the TimeColumnId or the
		/// TimeColumnName the whole input file is outputted.
		/// Default to -1.
		/// </summary>
		// Token: 0x06005223 RID: 21027 RVA: 0x00077B37 File Offset: 0x00075D37
		public void SetTimeColumnId(int idx)
		{
			vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_SetTimeColumnId_13(base.GetCppThis(), idx);
		}

		// Token: 0x06005224 RID: 21028
		[DllImport("Kitware.VTK.IOInfovis.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTemporalDelimitedTextReader_SetTimeColumnName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string name);

		/// <summary>
		/// Get/Set the name of the column to use as time indicator.
		/// Ignored if TimeColumnId is not equal to -1.
		/// If no column has been chosen using either the TimeColumnId or the
		/// TimeColumnName the whole input file is outputted.
		/// Default to empty string.
		/// </summary>
		// Token: 0x06005225 RID: 21029 RVA: 0x00077B47 File Offset: 0x00075D47
		public void SetTimeColumnName(string name)
		{
			vtkTemporalDelimitedTextReader.vtkTemporalDelimitedTextReader_SetTimeColumnName_14(base.GetCppThis(), name);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007B1 RID: 1969
		public new const string MRFullTypeName = "Kitware.VTK.vtkTemporalDelimitedTextReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040007B2 RID: 1970
		public new static readonly string MRClassNameKey = "class vtkTemporalDelimitedTextReader";
	}
}
